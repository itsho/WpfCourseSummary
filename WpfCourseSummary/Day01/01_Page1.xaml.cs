using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace WpfApplication01
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}