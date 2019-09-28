using MinistryApp.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace MinistryApp.Converters
{
    class SerciveStatusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ServiceStatus status = (ServiceStatus)value;
            switch (status)
            {
                case ServiceStatus.AssignedTo:
                    return "Assigned To Section Head Edu";
                case ServiceStatus.Completed:
                    return "Completed";
                default:
                    return "NA";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
