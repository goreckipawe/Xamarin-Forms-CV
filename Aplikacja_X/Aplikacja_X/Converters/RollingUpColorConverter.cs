using System;
using System.Globalization;
using Xamarin.Forms;

namespace Aplikacja_X.Converters
{
    class RollingUpColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.ToString() == "")
            {
                return "#03A9F4";
            }
            else {
                return "#34eb43";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
