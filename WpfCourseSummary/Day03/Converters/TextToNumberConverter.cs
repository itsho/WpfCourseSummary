using System;
using System.Windows.Data;

namespace WpfCourseSummary.Day03.Converters
{
    public class TextToNumberConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
            {
                return null;
            }
            string str = value.ToString();
            if (String.Compare(str, "Big", true) == 0)
            {
                return 200;
            }

            if (String.Compare(str, "Small", true) == 0)
            {
                return 5;
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}