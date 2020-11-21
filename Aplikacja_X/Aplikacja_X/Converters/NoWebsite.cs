using System;
using System.Globalization;
using Xamarin.Forms;

namespace Aplikacja_X.Converters
{
    class NoWebsite : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.ToString() == "")
            {
                return "No website available";
            }
            else
            {
                return value.ToString();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
