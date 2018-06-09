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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication01
{
    /// <summary>
    /// Interaction logic for _03_Animation2.xaml
    /// </summary>
    public partial class _03_Animation2 : Page
    {
        public _03_Animation2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Storyboard beginStoryboard= (FindResource("myAnim1") as Storyboard);
            beginStoryboard.Begin();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Storyboard beginStoryboard = (Resources["myAnim2"] as Storyboard);
            beginStoryboard.Begin();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Storyboard beginStoryboard = (FindResource("myAnim1") as Storyboard);
            beginStoryboard.Stop();
            Storyboard beginStoryboard2 = (FindResource("myAnim2") as Storyboard);
            beginStoryboard2.Stop();
            Storyboard beginStoryboard3 = (FindResource("myAnim3") as Storyboard);
            beginStoryboard3.Stop();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Storyboard beginStoryboard = (Resources["myAnim3"] as Storyboard);
            beginStoryboard.Begin();
        }
    }
}
