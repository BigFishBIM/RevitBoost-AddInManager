using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace BindConversion
{
    public class BoolToIsCheck : IValueConverter
    {
        public object Convert(object o, Type type, object parameter, CultureInfo culture)
        {
            var isChecked = CheckBox.IsCheckedProperty;
            if ((bool)parameter == false)
            {
                //isChecked = 
            }
            return isChecked;
        }

        public object ConvertBack(object o, Type type, object parameter, CultureInfo culture) => null;
    }
}