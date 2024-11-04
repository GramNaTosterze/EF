using System.Collections.ObjectModel;
using EF.Domain.Models;

namespace EF.UI.Views {
    using Terminal.Gui;
    
    
    public partial class UpdatePerson
    {
        private readonly List<Action> _updateActions = [];

        public UpdatePerson(App app, Person person)
        {
            InitializeComponent();
            TogleCapitalVisibility();

            if (person.Name == "" && person.Surname == "") 
            {
                Title = "Add new person";
                publicFigureCheckBox.Visible = true;
            }
            else
                Title = $"Update {person}";
        
            if (person is PublicFigure pf && person.Name != "" && person.Surname != "")
            {
                capitalTextField.Text = $"{pf.Capital}";
                TogleCapitalVisibility();
            }

            var id = person.Id;
            
            nameTextField.Text = person.Name;
            surnameTextField.Text = person.Surname;
            phonenumberTextField.Text = person.PhoneNumber ?? "";

            genderComboBox.Text = $"{person.Gender}";
            genderComboBox.SetSource(new ObservableCollection<Gender>(Enum.GetValues<Gender>()));
            genderComboBox.Height = Enum.GetValues<Gender>().Length + 1;
            var i = 0;
            foreach (var gender in Enum.GetValues<Gender>())
            {
                if (gender == person.Gender)
                {
                    genderComboBox.SelectedItem = i;
                    break;
                }
                i++;
            }

            publicFigureCheckBox.CheckedStateChanging += (_, e) =>
            {
                switch (e.NewValue)
                {
                    case CheckState.Checked:
                        TogleCapitalVisibility();
                        break;
                    case CheckState.UnChecked:
                    case CheckState.None:
                        TogleCapitalVisibility();
                        break;
                }
            };

            updateButton.Accept += (_, _) =>
            {
                if (app.PersonService.GetById(id) is not null)
                {
                    // Update if exists in database
                    if (person.Name != nameTextField.Text)
                        app.PersonService.UpdateName(id, nameTextField.Text);
                    if (person.Surname != surnameTextField.Text)
                        app.PersonService.UpdateSurname(id, surnameTextField.Text);
                    if (person.PhoneNumber != phonenumberTextField.Text)
                        app.PersonService.UpdatePhoneNumber(id, phonenumberTextField.Text);

                    var gender = Enum.GetValues<Gender>()[genderComboBox.SelectedItem];
                    if (person.Gender != gender)
                        app.PersonService.UpdateGender(id, gender);
                    if (person.PhoneNumber != phonenumberTextField.Text)
                        app.PersonService.UpdatePhoneNumber(id, phonenumberTextField.Text);

                    if (person is PublicFigure pf)
                    {
                        var capital = int.Parse(capitalTextField.Text);
                        if (pf.Capital != capital)
                            app.PublicFigureService.UpdateCapital(id, capital);
                    }


                    foreach (var action in _updateActions)
                        action();
                }
                else
                {
                    // Add to database
                    if (person is PublicFigure)
                        app.PublicFigureService.Create(person);
                    else
                        app.PersonService.Create(person);
                }

                app.MainView();
            };
            backButton.Accept += (_, _) => app.MainView();

            changePartnerButton.Accept += (_, _) =>
            {
                Add(new SelectorView(this, app.PersonService.GetAll(), o =>
                {
                    if (o is not Person partner) return;
                    _updateActions.Add(() => app.PersonService.UpdateParent(person.Id, partner.Id));
                    person.Partner = partner;
                }));
            };

            addParentButton.Accept += (_, _) =>
            {
                Add(new SelectorView(this, app.PersonService.GetAll(), o =>
                {
                    if (o is not Person parent) return;
                    _updateActions.Add(() => app.PersonService.AddParent(person.Id, parent.Id));
                    person.Parents.Add(parent);
                }));
            };
            removeParentButton.Accept += (_, _) =>
            {
                Add(new SelectorView(this, person.Parents, o =>
                {
                    if (o is not Person parent) return;
                    _updateActions.Add(() => app.PersonService.RemoveParent(person.Id, parent.Id));
                    person.Parents.Remove(parent);
                }));
            };
            
            addChildButton.Accept += (_, _) =>
            {
                Add(new SelectorView(this, app.PersonService.GetAll(), o =>
                {
                    if (o is not Person child) return;
                    _updateActions.Add(() => app.PersonService.AddChild(person.Id, child.Id));
                    person.Children.Add(child);
                }));
            };
            removeChildButton.Accept += (_, _) =>
            {
                Add(new SelectorView(this, person.Children, o =>
                {
                    if (o is not Person child) return;
                    _updateActions.Add(() => app.PersonService.RemoveChild(person.Id, child.Id));
                    person.Children.Remove(child);
                }));
            };
            
            addSiblingButton.Accept += (_, _) =>
            {
                Add(new SelectorView(this, app.PersonService.GetAll(), o =>
                {
                    if (o is not Person sibling) return;
                    _updateActions.Add(() => app.PersonService.AddSibling(person.Id, sibling.Id));
                    person.Siblings.Add(sibling);
                }));
            };
            removeSiblingButton.Accept += (_, _) =>
            {
                Add(new SelectorView(this, person.Siblings, o =>
                {
                    if (o is not Person sibling) return;
                    _updateActions.Add(() => app.PersonService.RemoveSibling(person.Id, sibling.Id));
                    person.Siblings.Remove(sibling);
                }));
            };

            addEmploymentButton.Accept += (_, _) =>
            {
                Add(new SelectorView(this, app.EmploymentService.GetAll(), o =>
                {
                    if (o is not Employment employment) return;
                    _updateActions.Add(() => app.PersonService.AddEmployment(person.Id, employment.Id));
                    person.Employments.Add(employment);
                }));
            };
            removeEmploymentButton.Accept += (_, _) =>
            {
                Add(new SelectorView(this, person.Employments, o =>
                {
                    if (o is not Employment employment) return;
                    _updateActions.Add(() => app.PersonService.RemoveEmployment(person.Id, employment.Id));
                    person.Employments.Remove(employment);
                }));

            };
        }

        private void TogleCapitalVisibility()
        {
            capitalLabel.Visible = !capitalLabel.Visible;
            capitalTextField.Visible = !capitalTextField.Visible;
            (capitalLabel.Y, genderLabel.Y) = (genderLabel.Y, capitalLabel.Y);
        }
    }
}
