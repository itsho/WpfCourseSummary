using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication01
{
    /// <summary>
    /// Interaction logic for _02_ContolTemplate.xaml
    /// </summary>
    public partial class _02_ContolTemplate : Page
    {
        public _02_ContolTemplate()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("test");
        }
    }
}
