using MauiKeypad.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiKeypad.ViewModels
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        private int _code;
        private EntryState _state;

        public int Code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
            }
        }

        public EntryState State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
            }
        }
        public MainViewModel()
        {

        }

        #region MVVM
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion //MVVM
    }
}
