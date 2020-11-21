using System;
using System.Globalization;
using Xamarin.Forms;

namespace Aplikacja_X.Converters
{
    class RollingUpYesNo : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.ToString() == "")
            {
                return "Nothing to add.";
            }
            else
            {
                return value;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
