namespace EF.UI.Views {
    using Terminal.Gui;
    
    
    public partial class FakeDataView {
        
        public FakeDataView(App app) {
            InitializeComponent();

            this.backButton.Accept += (_, _) => app.MainView(); 
            this.generateButton.Accept += (_, _) =>
            {
                try
                {
                    var numOfRandPeople = int.Parse(peopleTextField.Text);
                    var numOfRandEmployments = int.Parse(employmentsTextField.Text);
                    var numOfRandPublicFigures = int.Parse(publicFiguresTextField.Text);

                    if (numOfRandPeople != 0)
                    {
                        var partnerProc = int.Parse(partnerPercTextField.Text);
                        var parentProc = int.Parse(parentPercTextField.Text);
                        var siblingProc = int.Parse(siblingPercTextField.Text);
                        app.PersonService.Random(numOfRandPeople, partnerProc, parentProc, siblingProc);
                    }

                    if (numOfRandEmployments != 0)
                    {
                        var employmentProc = int.Parse(employmentPercTextField.Text);
                        app.EmploymentService.Random(numOfRandEmployments, employmentProc);
                    }

                    if (numOfRandPublicFigures != 0)
                    {
                        var partnerProc = int.Parse(partnerPercTextField.Text);
                        var parentProc = int.Parse(parentPercTextField.Text);
                        var siblingProc = int.Parse(siblingPercTextField.Text);
                        app.PublicFigureService.Random(numOfRandPublicFigures, partnerProc, parentProc, siblingProc);
                    }

                    app.MainView();
                }
                catch (Exception ex)
                {
                    MessageBox.Query("", $"{ex.Message}", "Ok");
                }
            };
        }
    }
}
