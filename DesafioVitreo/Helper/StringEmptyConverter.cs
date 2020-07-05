using System;
using System.Globalization;
using Xamarin.Forms;

namespace DesafioVitreo.Helper
{
    public class StringEmptyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string sRet = string.Empty;

            if (value == null || string.IsNullOrEmpty(System.Convert.ToString(value)))
            {

                if (culture.Name == "en-US")
                    sRet = "The Marvel API did not provide this description.";
                else
                    sRet = "A API da Marvel não disponibilizou essa descrição.";

                return sRet;
            }
            else
                return value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
