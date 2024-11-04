using EF.Domain.Models;

namespace EF.UI.Views {
    
    
    public partial class UpdateEmployment
    {
        private readonly List<Action> _updateActions = [];
        public UpdateEmployment(App app, Employment employment) {
            InitializeComponent();
            if (employment.Company == "" && employment.Contract == "")
                Title = "Add new employment";
            else
                Title = $"Update {employment}";

            var id = employment.Id;

            companyTextField.Text = employment.Company;
            contractTextField.Text = employment.Contract;
            payTextField.Text = $"{employment.Pay}";
            
            updateButton.Accept += (_, _) =>
            {
                if (app.PersonService.GetById(id) is not null)
                {
                    // Update if exists in database
                    if (employment.Company != companyTextField.Text)
                        app.EmploymentService.UpdateCompany(id, companyTextField.Text);
                    if (employment.Contract != contractTextField.Text)
                        app.EmploymentService.UpdateContract(id, contractTextField.Text);
                    if(employment.Pay != Double.Parse(payTextField.Text))
                        app.EmploymentService.UpdatePay(id, Double.Parse(payTextField.Text));

                    foreach (var action in _updateActions)
                        action();
                }
                else
                {
                    // Add to database
                    app.EmploymentService.Create(employment);
                }

                app.MainView();
            };
            backButton.Accept += (_, _) => app.MainView();

            addEmployeeButton.Accept += (_, _) =>
            {
                Add(new SelectorView(this, app.PersonService.GetAll(), o =>
                {
                    if (o is not Person employee) return;
                    _updateActions.Add(() => app.EmploymentService.UpdateEmployee(employment.Id, employee.Id));
                    employment.Employee = employee;
                }));
            };
            removeEmployeeButton.Accept += (_, _) =>
            {
                _updateActions.Add(() => app.EmploymentService.RemoveEmployee(employment.Id));
                employment.Employee = null;
            };
        }
    }
}
