using System;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfCourseSummary.Day03.Converters
{
    public class ColorToDoubleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
            {
                return null;
            }

            SolidColorBrush s = value as SolidColorBrush;

            if (s != null && s.Color == Colors.Red)
            {
                return 0.1;
            }

            return 1.0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}