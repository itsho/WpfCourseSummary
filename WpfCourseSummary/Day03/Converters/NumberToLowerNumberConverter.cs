using System;
using System.Windows.Data;

namespace WpfCourseSummary.Day03.Converters
{
    public class NumberToLowerNumberConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
            {
                return null;
            }

            double intCurrValue = double.Parse(value.ToString());

            return 100 - intCurrValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}