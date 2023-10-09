using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MostActiveVolcanoes
{
    public class CountryCodeToNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string countryCode)
            {
                switch (countryCode)
                {
                    case "ID": return "Indonesia";
                    case "JP": return "Japan";
                    case "US": return "United States";
                    case "RU": return "Russia";
                    case "CL": return "Chile";
                    case "EC": return "Ecuador";
                    case "TO": return "Tonga";
                    case "IS": return "Iceland";
                    case "FR": return "France";
                    case "MX": return "Mexico";
                    case "PH": return "Philippines";
                    default: return countryCode;
                }
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
