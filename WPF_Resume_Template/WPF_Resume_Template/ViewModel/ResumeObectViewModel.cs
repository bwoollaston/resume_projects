using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPF_Resume_Template.ViewModel
{
    internal class ResumeObectViewModel : ResumeObjectBase
    {
        public ResumeObectViewModel()
        {
            Items = new ObservableCollection<string>();
        }
        private ObservableCollection<string> _items;
        public ObservableCollection<string> Items
        {
            get { return _items; }
            set { _items = value; OnPropertyChanged();}
        }

    }
}
