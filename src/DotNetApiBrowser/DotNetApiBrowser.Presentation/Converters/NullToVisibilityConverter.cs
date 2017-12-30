﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Waf.DotNetApiBrowser.Presentation.Converters
{
    public class NullToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool invert = string.Equals(parameter as string, "invert", StringComparison.OrdinalIgnoreCase);
            if (invert)
            {
                return value == null ? Visibility.Visible : Visibility.Collapsed;
            }
            return value != null ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
