using System;
using System.Globalization;
using Xamarin.Forms;

namespace LACare
{
    public class DateTimeConverter : IValueConverter
    {
        public object Convert(object value,
                           Type targetType,
                           object parameter,
                           CultureInfo culture)
        {
            if (value != null)
            {
                return ((DateTime)value).ToString("MMMM yyyy");
            }
            else
            {
                return String.Empty;
            }
        }

        public object ConvertBack(object value,
                                  Type targetType,
                                  object parameter,
                                  CultureInfo culture)
        {
            return DateTime.Parse(value.ToString());
        }
    }
}
