using System;
using System.Globalization;
using System.Windows.Data;

namespace Walkman.Wpf.CustomControls.Converters
{
    public class SizeAnimationConverter : IValueConverter
    {
        public static readonly SizeAnimationConverter Instance = new SizeAnimationConverter();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double currentWidth = System.Convert.ToDouble(value);
            double percent = System.Convert.ToDouble(parameter);
            return currentWidth + currentWidth * percent;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
