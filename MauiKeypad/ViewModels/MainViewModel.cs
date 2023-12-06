using MauiKeypad.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiKeypad.ViewModels
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        private string _code;
        private EntryState _state;

        public string Code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
                OnPropertyChanged();
            }
        }

        public Command<string> AddNumber { get; set; }

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
            Code = "";
            AddNumber = new Command<string>((x) =>
            {
                if (Code.Length < 6)
                {
                    Code += x;
                }
            });
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
