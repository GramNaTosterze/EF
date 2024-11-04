using System.Collections.ObjectModel;
using System.Runtime.InteropServices.ComTypes;
using EF.Domain.Models;
using Terminal.Gui;

namespace EF.UI.Views {


    public partial class MainView
    {
        public MainView(App app)
        {
            InitializeComponent();

            object? selectedItem = null;
            
            personListView.SetSource(new ObservableCollection<Person>(app.PersonService.GetAll()));
            employmentListView.SetSource(new ObservableCollection<Employment>(app.EmploymentService.GetAll()));
            
            employmentListView.SelectedItemChanged += (_, e) =>
            {
                selectedItem = e.Value;
                var employment = (Employment)e.Value;
                infoTextView.Text = string.Join(
                    Environment.NewLine,
                    $"Type of contract: {employment.Contract}",
                    $"Pay: {employment.Pay}",
                    $"Employed: {string.Join(", ", app.PersonService.GetByEmployment(employment))}");
            };
            
            personListView.SelectedItemChanged += (_, e) =>
            {
                selectedItem = e.Value;
                var person = (Person)e.Value;
                infoTextView.Text = string.Join(
                    Environment.NewLine,
                    $"Name: {person.Name}",
                    $"Surname: {person.Surname}",
                    $"Gender: {person.Gender}",
                    $"Phone Number: {person.PhoneNumber}",
                    $"Partner: {person.Partner}",
                    $"Parents: {string.Join(", ", person.Parents)}",
                    $"Children: {string.Join(", ", person.Children)}",
                    $"Siblings: {string.Join(", ", person.Siblings.Concat(person.SiblingTo))}",
                    $"Employments: {string.Join(", ", person.Employments)}");
                if (person is PublicFigure figure)
                {
                    infoTextView.Text += $"{Environment.NewLine}Capital: {figure.Capital}";
                }
            };

            addFakeDataButton.Accept += (_, _) => app.ChangeView(new FakeDataView(app));
            querieButton.Accept += (_, _) => app.ChangeView(new QueriesView(app));

            updateButton.Accept += (_, _) =>
            {
                switch (selectedItem)
                {
                    case null:
                        return;
                    case Person person:
                        app.ChangeView(new UpdatePerson(app, person));
                        return;
                    case Employment employment:
                        //TODO: create UpdateEmploymentView
                        return;
                        
                }
            };

            addPersonButton.Accept += (_, _) =>
            {
                var person = new PublicFigure()
                {
                    Name = "",
                    Surname = "",
                    Gender = Gender.Other,
                };
                app.ChangeView(new UpdatePerson(app, person));
            };

           addEmploymentButton.Accept += (_, _) =>
            {
                //TODO: create UpdateEmploymentView
            };

            deleteButton.Accept += (_, _) =>
            {
                switch (selectedItem)
                {
                    case null:
                        MessageBox.Query("", "Item not selected", "Ok");
                        return;
                    case Person person:
                        app.PersonService.DeleteById(person.Id);
                        personListView.SetSource(new ObservableCollection<Person>(app.PersonService.GetAll()));
                        return;
                    case Employment employment:
                        app.EmploymentService.DeleteById(employment.Id);
                        employmentListView.SetSource(new ObservableCollection<Employment>(app.EmploymentService.GetAll()));
                        return;
                }
            };


        }
    }
}
