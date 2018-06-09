using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApplication01
{
    /// <summary>
    /// Interaction logic for ControlsHierarchy.xaml
    /// </summary>
    public partial class ControlsHierarchy : Page
    {
        public ControlsHierarchy()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            // select first tab
            tabControl.SelectedIndex = 0;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            // select second tab
            tabControl.SelectedIndex = 1;
        }

        private Color? GetColorFromTextBlock(TextBlock tb)
        {
            return ColorConverter.ConvertFromString(tb.Text) as Color?;
        }

        private void SetEllipseColor(Color? selectedColor)
        {
            if (selectedColor != null)
            {
                ellipse.Fill = new SolidColorBrush((Color)selectedColor);
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // get selected color from the text
            var selectedColor = GetColorFromTextBlock((TextBlock)lstColors.SelectedItem);

            SetEllipseColor(selectedColor);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // get selected color from the text
            var selectedColor = GetColorFromTextBlock((TextBlock)cmbColors.SelectedItem);

            SetEllipseColor(selectedColor);
        }
    }
}