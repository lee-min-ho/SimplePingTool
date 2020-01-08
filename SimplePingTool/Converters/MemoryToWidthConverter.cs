﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace ITBox.Converters
{
    public class MemoryToWidthConverter : IMultiValueConverter
    {

        public object Convert(object[] value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value[0] is double && value[1] is double && value[2] is ListBox)
            {
                var decimalPercentage = ConvertToPercentage((double)value[0], (double)value[1]);
                var containerWidth = ((ListBox)value[2]).ActualWidth;

                return decimalPercentage * containerWidth;

            }

            else
                return null;
        }

        public object[] ConvertBack(object value, Type[] targetType, object parameter, CultureInfo culture)
        {
            throw new Exception("not defined");
        }

        private double ConvertToPercentage(double valueToConvert, double total)
        {
            return (valueToConvert / total);
        }
    }
}