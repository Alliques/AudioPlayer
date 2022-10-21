using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace Walkman.UI.Converter
{
    /// <summary>
    /// InLessThanConverter
    /// </summary>
    public class InLessThanConverter : IValueConverter
    {
        public static readonly InLessThanConverter Instance = new InLessThanConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo cultureInfo)
        {
            double doubleValue = System.Convert.ToDouble(value);
            double compareToValue = System.Convert.ToDouble(parameter);

            return doubleValue < compareToValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// InGreaterThanConverter
    /// </summary>
    public class InGreaterThanConverter : IValueConverter
    {
        public static readonly InGreaterThanConverter Instance = new InGreaterThanConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo cultureInfo)
        {
            double doubleValue = System.Convert.ToDouble(value);
            double compareToValue = System.Convert.ToDouble(parameter);

            return doubleValue < compareToValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
