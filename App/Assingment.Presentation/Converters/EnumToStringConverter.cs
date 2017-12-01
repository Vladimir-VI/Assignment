using System;
using System.Globalization;
using System.Windows.Data;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Assingment.Presentation.Converters
{
    public class EnumToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return
                value.GetType().GetField(value.ToString()).GetCustomAttribute<DisplayAttribute>().Name;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
