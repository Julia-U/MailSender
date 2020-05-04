using MVVMCalc.Model;

namespace MVVMCalc.ViewModel
{
    class CalculatorViewModel : ViewModelBase
    {
        private readonly Calculator _calculator;
        private string _result;

        public CalculatorViewModel()
        {
            _calculator = new Calculator();
        }

        public int A
        {
            get => _calculator.A;
            set
            {
                _calculator.A = value;
                //Calc();
            }
        }

        public int B
        {
            get => _calculator.B;
            set
            {
                _calculator.B = value;
                //Calc();
            }
        }

        public string Result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged(nameof(Result));
            }
        }

        //private void Calc()
        //{
        //    Result = _calculator.Sum().ToString();
        //}

        //private RelayCommand _calcCommand;
        //public RelayCommand CalcCommand
        //{
        //    get
        //    {
        //        return _calcCommand ?? (_calcCommand = new RelayCommand(ExecuteCalcCommand, CanCalcCommand));                
        //    }
        //}

        //public void ExecuteCalcCommand(object parameter)
        //{
        //    Calc();
        //}

        //public bool CanCalcCommand(object parameter)
        //{
        //    return B != 0;
        //}

        /// <summary>
        /// сложение
        /// </summary>
        private void Sum()
        {
            Result = _calculator.Sum().ToString();
        }

        private RelayCommand _sumCommand;
        public RelayCommand SumCommand
        {
            get
            {
                return _sumCommand ?? (_sumCommand = new RelayCommand(ExecuteSumCommand));
            }
        }

        public void ExecuteSumCommand(object parameter)
        {
            Sum();
        }

        

        /// <summary>
        /// вычитание
        /// </summary>
        private void Sub()
        {
            Result = _calculator.Sub().ToString();
        }

        private RelayCommand _subCommand;
        public RelayCommand SubCommand => _subCommand ?? (_subCommand = new RelayCommand(ExecuteSubCommand));

        public void ExecuteSubCommand(object parameter)
        {
            Sub();
        }

        /// <summary>
        /// умножение
        /// </summary>
        private void Mult()
        {
            Result = _calculator.Mult().ToString();
        }

        private RelayCommand _multCommand;
        public RelayCommand MultCommand
        {
            get
            {
                return _multCommand ?? (_multCommand = new RelayCommand(ExecuteMultCommand));
            }
        }

        public void ExecuteMultCommand(object parameter)
        {
            Mult();
        }

        /// <summary>
        /// деление
        /// </summary>
        private void Div()
        {
            Result = _calculator.Div().ToString();
        }

        private RelayCommand _divCommand;
        public RelayCommand DivCommand
        {
            get
            {
                return _divCommand ?? (_divCommand = new RelayCommand(ExecuteDivCommand, CanCalcCommand));
            }
        }

        public void ExecuteDivCommand(object parameter)
        {
            Div();
        }

        public bool CanCalcCommand(object parameter)
        {
            return B != 0;
        }

        /// <summary>
        /// возведение в степень
        /// </summary>
        private void Pow()
        {
            Result = _calculator.Pow().ToString();
        }

        private RelayCommand _powCommand;
        public RelayCommand PowCommand
        {
            get
            {
                return _powCommand ?? (_powCommand = new RelayCommand(ExecutePowCommand));
            }
        }

        public void ExecutePowCommand(object parameter)
        {
            Pow();
        }
    }
}
