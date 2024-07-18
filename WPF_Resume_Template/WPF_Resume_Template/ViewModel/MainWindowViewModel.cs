﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Resume_Template.ViewModel
{
    internal class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            ProgViewModel = new ProgViewModel();
        }
        private ProgViewModel progViewModel;
        public ProgViewModel ProgViewModel
        {
            get { return progViewModel; }
            set
            {
                progViewModel = value;
                OnPropertyChanged();
            }
        }
    }
}
