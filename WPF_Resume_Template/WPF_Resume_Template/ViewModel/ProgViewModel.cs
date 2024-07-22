using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Resume_Template.ViewModel
{
    internal class ProgViewModel : ViewModelBase
    {
        public ProgViewModel()
        {
            SummaryViewModel = new ResumeObectViewModel() { Title = "SUMMARY" };
            SummaryViewModel.Items.Add("Hello Items");

            LanguagesViewModel = new ResumeProgressObjectViewModel() { Title="PROGRAMING LANGUAGES"};
            LanguagesViewModel.AddItem(new ProgressItemViewModel("C", 100));
        }
        private ResumeObectViewModel _summaryViewModel;
        public ResumeObectViewModel SummaryViewModel
        {
            get { return _summaryViewModel; }
            set { _summaryViewModel = value; OnPropertyChanged(); }
        }
        private ResumeProgressObjectViewModel _languagesViewModel;
        public ResumeProgressObjectViewModel LanguagesViewModel
        {
            get { return _languagesViewModel; }
            set { _languagesViewModel = value; OnPropertyChanged(); }
        }
    }
}
