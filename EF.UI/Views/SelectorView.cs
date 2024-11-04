using System.Collections.ObjectModel;
using Terminal.Gui;
namespace EF.UI.Views {
    
    
    public partial class SelectorView
    {
        public SelectorView(View parent, dynamic items, Action<object> setItem) {
            InitializeComponent();

            
            List<View> siblingViews = parent.Subviews.Where(v => v.Visible).ToList();
            siblingViews.ForEach(sv => sv.Visible = false);
            Visible = true;

            selectorListView.SetSource(new ObservableCollection<object>(items));
            if (selectorListView.Source.Length == 0)
            {   
                siblingViews.ForEach(sv => sv.Visible = true);
                parent.Remove(this);
            }
            selectorListView.SelectedItemChanged += (_, e) =>
            {
                setItem(e.Value);
                siblingViews.ForEach(sv => sv.Visible = true);
                parent.Remove(this);
            };
        }
    }
}
