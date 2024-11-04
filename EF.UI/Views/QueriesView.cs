using System.Collections.ObjectModel;
using System.Dynamic;
using EF.Domain.Models;

namespace EF.UI.Views {
    using System.Reflection;
    using Terminal.Gui;
    
    
    public partial class QueriesView {
        
        public QueriesView(App app) {
            InitializeComponent();

            outputListView.Source = null;
            genderComboBox.SetSource(new ObservableCollection<Gender>(Enum.GetValues<Gender>()));
            genderComboBox.Height = Enum.GetValues<Gender>().Length + 1;
            genderComboBox.SelectedItem = 0;

            personQuerieButton.Accept += (_, _) =>
            {
                var gender = Enum.GetValues<Gender>()[genderComboBox.SelectedItem];
                var person = app.PersonService.FindPersonWithTheMostGrandkids(gender);
                if (person is null)
                    outputListView.Source = null;
                else
                    outputListView.SetSource(new ObservableCollection<Person>([person]));
            };
            employmentQuerieButton.Accept += (_, _) =>
            {
                var averagePay = app.EmploymentService.AveragePerContractType();
                List<string> averagePayStr = [];
                
                foreach (var ap in averagePay)
                {
                    Type type = ap.GetType();
                    var fields = type.GetProperties();
                    averagePayStr.Add($"{fields[0].GetValue(ap, null)}({fields[1].GetValue(ap, null)}) - {fields[2].GetValue(ap, null)}");
                }

                outputListView.SetSource(new ObservableCollection<dynamic>(averagePayStr));
            };
            publicFigureQuerieButton.Accept += (_, _) =>
            {
                var person = app.PublicFigureService.Query();
                outputListView.SetSource(new ObservableCollection<Person>([person]));
            };
            backButton.Accept += (_, _) => app.MainView();
        }
    }
}
