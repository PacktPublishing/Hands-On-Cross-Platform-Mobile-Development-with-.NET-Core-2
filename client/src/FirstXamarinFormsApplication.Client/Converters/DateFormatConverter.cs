﻿using System;
using System.Globalization;
using Xamarin.Forms;

namespace FirstXamarinFormsApplication.Client.Converters
{
public class DateFormatConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if(value is DateTime date)
        {
            return date.ToShortDateString();
        }

        return null;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        // No Need to implement ConvertBack for OneTime and OneWay bindings.
        throw new NotImplementedException();
    }
}
}
