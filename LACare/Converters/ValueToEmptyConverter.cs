using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace LACare
{
    class ValueToEmptyConverter : IValueConverter
    {
        /// <summary>
        /// Convert 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
           
            bool visibility = false;

            if (value is DateTime)
            {
                DateTime temp = (DateTime)value;
                if (temp.Day == 1)
                    visibility = true;
            }
            return visibility;

            //string visibility = "";

            //if (value is DateTime)
            //{
            //    DateTime temp = (DateTime)value;
            //    if (temp.Day == 1)
            //        visibility = temp.Date.ToShortDateString();
            //}
            //return visibility;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

