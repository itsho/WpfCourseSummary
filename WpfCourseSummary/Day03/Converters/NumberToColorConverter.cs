using System;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfCourseSummary.Day03.Converters
{
    public class NumberToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
            {
                return null;
            }

            double intCurrValue = double.Parse(value.ToString());

            if (intCurrValue >= 0 && intCurrValue <= 20)
            {
                return new SolidColorBrush(Colors.Red);
            }
            if (intCurrValue > 20 && intCurrValue <= 70)
            {
                return new SolidColorBrush(Colors.Green);
            }
            if (intCurrValue > 70 && intCurrValue <= 100)
            {
                return new SolidColorBrush(Colors.Blue);
            }

            return new SolidColorBrush(Colors.White);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}