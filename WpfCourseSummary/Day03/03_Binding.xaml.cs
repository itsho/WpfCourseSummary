using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WpfApplication01
{
    public partial class _03_Binding : Page
    {
        public _03_Binding()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Binding objBinding = new Binding();
            objBinding.Source = objEllipse;
            objBinding.Path = new PropertyPath("Height");
            sldSlider3.SetBinding(Slider.ValueProperty, objBinding);
        }
    }
}