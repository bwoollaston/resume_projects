using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Resume_Template
{
    /// <summary>
    /// Interaction logic for ResumeObject.xaml
    /// </summary>
    public partial class ResumeObject : UserControl
    {
        public ResumeObject()
        {
            InitializeComponent();
            Items = new ObservableCollection<string>();
            this.DataContext = this;
        }

        public static readonly DependencyProperty TitleSizeProperty =
            DependencyProperty.Register("TitleSize", typeof(int), typeof(ResumeObject), new PropertyMetadata(18));

        public int TitleSize
        {
            get => (int)GetValue(TitleSizeProperty);
            set => SetValue(TitleSizeProperty, value);
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(ResumeObject));
        
        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public static readonly DependencyProperty AccentColorProperty =
            DependencyProperty.Register("AccentColorBrush", typeof(Brush), typeof(ResumeObject), new PropertyMetadata(Brushes.Black));
        public Brush AccentColorBrush
        {
            get => (Brush)GetValue(AccentColorProperty);
            set => SetValue(AccentColorProperty, value);
        }

        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(ObservableCollection<string>), typeof(ResumeObject), new PropertyMetadata(new ObservableCollection<string>(), OnItemsChanged));

        public ObservableCollection<string> Items
        {
            get => (ObservableCollection<string>)GetValue(ItemsProperty);
            set => SetValue(ItemsProperty, value);
        }

        private static void OnItemsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ResumeObject control)
            {
                control.ItemsPanel.Children.Clear();
                var items = (ObservableCollection<string>)e.NewValue;
                foreach (var item in items)
                {
                    control.ItemsPanel.Children.Add(new TextBlock { Text = item });
                }
            }
        }
    }
}
