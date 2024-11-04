using EF.UI.Views;
using EF.Application;
using EF.Infrastructure;
using Terminal.Gui;

namespace EF.UI {
    
    public sealed partial class App {
        private  MainView _mainView;
        
        public EFContext Context;
        public PersonService PersonService;
        public EmploymentService EmploymentService;
        public PublicFigureService PublicFigureService;

        public App() {
            InitializeComponent();
            Context = new EFContext();
            Context.Database.EnsureCreated();
            PersonService = new PersonService(Context);
            EmploymentService = new EmploymentService(Context);
            PublicFigureService = new PublicFigureService(Context);

            _mainView = new MainView(this);
            Add(_mainView);
        }

        public void ChangeView(Window view)
        {
            Remove(_mainView);
            Add(view);
        }

        public void MainView()
        {
            RemoveAll();
            _mainView = new MainView(this);
            Add(_mainView);
        }
    }
}
