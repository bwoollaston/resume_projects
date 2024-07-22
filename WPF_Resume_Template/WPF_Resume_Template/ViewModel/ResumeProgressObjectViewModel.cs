using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Resume_Template.ViewModel
{
    internal class ResumeProgressObjectViewModel : ResumeObjectBase
    {
        public ResumeProgressObjectViewModel()
        {
            Items = new ObservableCollection<ProgressItemViewModel>();
        }
        private ObservableCollection<ProgressItemViewModel> _items;
        public ObservableCollection<ProgressItemViewModel> Items
        {
            get { return _items; }
            set { _items = value; OnPropertyChanged(); }
        }
        public void AddItem(ProgressItemViewModel item)
        {
            Items.Add(item);
            Items = new ObservableCollection<ProgressItemViewModel>(Items);
        }
    }
}
