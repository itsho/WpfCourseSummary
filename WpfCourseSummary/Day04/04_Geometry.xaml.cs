using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication01.Day04
{
    public partial class _04_Geometry : Page
    {
        public _04_Geometry()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Path objPath = new Path
            {
                Stroke = new SolidColorBrush(Colors.Blue)
            };
            ImageBrush imgToFill = new ImageBrush
            {
                ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/BackgroundImage.jpg", UriKind.Absolute))
            };
            objPath.Fill = imgToFill;

            CombinedGeometry objGeometry = new CombinedGeometry();
            objGeometry.Geometry1 = new RectangleGeometry(new Rect(10, 20, 80, 70));
            objGeometry.Geometry2 = new EllipseGeometry(new Point(100, 90), 40, 40);

            objPath.Data = objGeometry;
            objCanvasCombindedGeo.Children.Add(objPath);

            // change location on canvas
            Canvas.SetLeft(objPath, 150 * objCanvasCombindedGeo.Children.Count);
            Canvas.SetTop(objPath, 25);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            objCanvasCombindedGeo.Children.Clear();
        }
    }
}