using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApplication01
{
    public partial class LayoutOnRunTime : Page
    {
        public LayoutOnRunTime()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            myGrid.ShowGridLines = true;
            myGrid.RowDefinitions.Add(new RowDefinition());
            myGrid.RowDefinitions.Add(new RowDefinition());
            myGrid.ColumnDefinitions.Add(new ColumnDefinition());
            myGrid.ColumnDefinitions.Add(new ColumnDefinition());

            // Canvas
            {
                Canvas objCanvas = new Canvas();
                myGrid.Children.Add(objCanvas);
                Grid.SetColumn(objCanvas, 0);
                Grid.SetRow(objCanvas, 0);

                {
                    Rectangle objRect = new Rectangle
                    { Width = 50, Height = 50, Fill = new SolidColorBrush(Colors.SteelBlue) };
                    Canvas.SetTop(objRect, 30);
                    Canvas.SetLeft(objRect, 30);
                    objCanvas.Children.Add(objRect);

                    Ellipse objEllipse = new Ellipse()
                    { Width = 30, Height = 50, Fill = new SolidColorBrush(Colors.SteelBlue) };
                    Canvas.SetTop(objEllipse, 70);
                    Canvas.SetLeft(objEllipse, 70);
                    objCanvas.Children.Add(objEllipse);
                }
            }

            // StackPanel
            {
                StackPanel objStack = new StackPanel();
                myGrid.Children.Add(objStack);
                Grid.SetColumn(objStack, 1);
                Grid.SetRow(objStack, 0);
                {
                    objStack.Children.Add(new Button() { Content = "Click Me" });
                    objStack.Children.Add(new Button() { Content = "Click Me" });
                    objStack.Children.Add(new Button() { Content = "Click Me" });
                }
            }

            // WrapPanel
            {
                WrapPanel objWrap = new WrapPanel();
                myGrid.Children.Add(objWrap);
                Grid.SetColumn(objWrap, 0);
                Grid.SetRow(objWrap, 1);
                {
                    objWrap.Children.Add(new Button() { Content = "Dont Click Me" });
                    objWrap.Children.Add(new Button() { Content = "Dont Click Me" });
                    objWrap.Children.Add(new Button() { Content = "Dont Click Me" });
                }
            }

            // Another Grid
            {
                Grid objInnerGrid = new Grid();
                objInnerGrid.RowDefinitions.Add(new RowDefinition());
                objInnerGrid.RowDefinitions.Add(new RowDefinition());
                objInnerGrid.ColumnDefinitions.Add(new ColumnDefinition());
                objInnerGrid.ColumnDefinitions.Add(new ColumnDefinition());

                myGrid.Children.Add(objInnerGrid);
                Grid.SetColumn(objInnerGrid, 1);
                Grid.SetRow(objInnerGrid, 1);
                {
                    Button btn1 = new Button();
                    objInnerGrid.Children.Add(btn1);
                    Grid.SetColumn(btn1, 0);
                    Grid.SetRow(btn1, 0);

                    Button btn2 = new Button();
                    objInnerGrid.Children.Add(btn2);
                    Grid.SetColumn(btn1, 1);
                    Grid.SetRow(btn1, 1);
                }
            }
        }
    }
}