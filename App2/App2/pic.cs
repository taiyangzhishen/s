using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
namespace App2
{
    class pic : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return 0;
        }
        public object ConvertBack(object value,Type targetType,object parameter,string language)
        {
            throw new NotImplementedException();
        }
    }

}
