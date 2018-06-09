using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace WpfApplication01
{
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}