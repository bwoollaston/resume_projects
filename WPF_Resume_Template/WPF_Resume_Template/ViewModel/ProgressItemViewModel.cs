using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Resume_Template.ViewModel
{
    internal class ProgressItemViewModel : ViewModelBase
    {
        public ProgressItemViewModel(string itemName, int progress)
        {
            ItemName = itemName;
            Progress = progress;
        }
        private string _itemName;
        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; OnPropertyChanged(); }
        }
        private int _progress=0;
        public int Progress
        {
            get { return _progress; }
            set { _progress = value; OnPropertyChanged(); }
        }
    }
}
