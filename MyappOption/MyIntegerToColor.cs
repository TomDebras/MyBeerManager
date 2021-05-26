using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace DossierFinal_Debras
{
    public class MyIntegerToColor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int val = System.Convert.ToInt32(value);
            SolidColorBrush brush;
            if (val <= 10)
            {
                brush = new SolidColorBrush(Colors.Red);
                return brush;
            }
            brush = new SolidColorBrush(Colors.Black);
            return brush;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
