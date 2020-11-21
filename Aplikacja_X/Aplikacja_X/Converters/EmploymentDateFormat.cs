using System;
using System.Globalization;
using Xamarin.Forms;

namespace Aplikacja_X.Converters
{
    class EmploymentDateFormat : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.ToString() == "")
            {
                return "Nowadays";
            }
            else
            {
                DateTime date = DateTime.ParseExact(value.ToString(), "MM/dd/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                return date.ToString("dd-MM-yyyy");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
