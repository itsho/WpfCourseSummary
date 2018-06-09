using System;
using System.Windows;

namespace WpfCourseSummary
{
    public partial class MainWindowContainer : Window
    {
        public MainWindowContainer()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("MainPage.xaml", UriKind.Relative));
        }
    }
}