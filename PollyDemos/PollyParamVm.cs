using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PollyDemos
{
    public class PollyParamVm: INotifyPropertyChanged
    {
        private int _inputValue;
        private int _usedInSimulation;
        public int UsedInSimulation
        {
            get
            {
                return _usedInSimulation;
            }
            set
            {
                OnPropertyChanged("StateOfSimulation");
                OnPropertyChanged();
                _usedInSimulation = value;
            }
        }
        public int InputValue
        {
            get => _inputValue;
            set
            {
                OnPropertyChanged();
                _inputValue = value;
            }
        }

        public bool StateOfSimulation => InputValue == UsedInSimulation;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
