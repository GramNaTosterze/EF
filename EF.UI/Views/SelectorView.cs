using System.Text.Json.Serialization.Metadata;

namespace EF.UI.Views {
    using EF.Domain.Models;
    using System.Collections.ObjectModel;
    using System.Linq;
    using Terminal.Gui;
    
    
    public partial class SelectorView
    {
        private readonly List<View> _siblingViews;
        public SelectorView(View parent, dynamic items, Action<object> SetItem) {
            InitializeComponent();

            
            _siblingViews = parent.Subviews.Where(v => v.Visible).ToList();
            _siblingViews.ForEach(sv => sv.Visible = false);
            Visible = true;

            selectorListView.SetSource(new ObservableCollection<object>(items));
            if (selectorListView.Source.Length == 0)
            {   
                _siblingViews.ForEach(sv => sv.Visible = true);
                parent.Remove(this);
            }
            selectorListView.SelectedItemChanged += (_, e) =>
            {
                SetItem(e.Value);
                _siblingViews.ForEach(sv => sv.Visible = true);
                parent.Remove(this);
            };
        }
    }
}
