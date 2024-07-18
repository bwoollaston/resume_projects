using System;
using System.Collections.Generic;
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

namespace WPF_Resume_Template
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult r = MessageBox.Show("Are you sure you wannt to quit?", "Application Closing", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (r == MessageBoxResult.Yes)
            {

                Application.Current.Shutdown();
            }
            else e.Cancel = true;
        }
        private void TitleBarFrame_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }
        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void MaximizeRestoreButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
            }
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (e.ChangedButton == MouseButton.Left)
                {
                    if (this.WindowState == WindowState.Maximized && e.ButtonState == MouseButtonState.Pressed)
                    {
                        Point relativePosition = Mouse.GetPosition(this);
                        double mouseX = relativePosition.X;
                        double mouseY = relativePosition.Y;
                        this.WindowState = WindowState.Normal;
                        Left = mouseX;
                        Top = mouseY;
                    }
                    this.DragMove();
                }
            }
            catch { }
        }
        private void Menu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Window_MouseDown(this, new MouseButtonEventArgs(e.MouseDevice, e.Timestamp, e.ChangedButton));
        }
        private void Card_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.SizeAll;
        }
        private void Card_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }
        private void Content_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }
    }
}
