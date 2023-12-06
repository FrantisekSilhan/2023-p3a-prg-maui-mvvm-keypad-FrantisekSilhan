using MauiKeypad.Models;
using System.Globalization;

namespace MauiKeypad.Converters
{
    internal class StateToColor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is EntryState)
            {
                switch (value)
                {
                    case (EntryState.InProgress):
                        return Color.FromRgb(10, 10, 10);
                    case (EntryState.Success):
                        return Color.FromRgb(10, 255, 10);
                    case (EntryState.Denied):
                        return Color.FromRgb(255, 10, 10);
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
