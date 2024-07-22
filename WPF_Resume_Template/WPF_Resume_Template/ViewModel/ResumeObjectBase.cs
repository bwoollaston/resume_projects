using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Resume_Template.ViewModel
{
    internal class ResumeObjectBase : ViewModelBase
    {
        public ResumeObjectBase() { }
        private string _title = "title";
        public string Title
        {
            get { return _title; }
            set { _title = value; OnPropertyChanged(); }
        }
        private int _titleSize = 16;
        public int TitleSize
        {
            get { return (int)_titleSize; }
            set { _titleSize = value; OnPropertyChanged(); }
        }
    }
}
