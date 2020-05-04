using System;

namespace MVVMCalc.Model
{
    public sealed class Calculator
    {
        //public static int Sum (int a, int b)
        //{
        //    return a + b;
        //}

        //public int Sum(int a, int b)
        //{
        //    return a + b;
        //}

        //private int _a = 0;

        //public Calculator(int a, int b)
        //{
        //    _a = a;
        //    _b = b;
        //}

        //public void SetB(int b)
        //{
        //    if (b != 0)
        //    {
        //        _b = b;
        //    }
        //    else
        //    {
        //        MessageBox.Show("b = 0");
        //    }

        //}

        //public void SetA(int a)
        //{
        //    _a = a;
        //}

        //public int A
        //{
        //    set
        //    {
        //        _a = value;
        //    }

        //    get
        //    {
        //        return _a;
        //    }
        //}

        //public int A
        //{
        //    get => _a;
        //    set => _a = value;
        //}



        //private int _b = 1;

        //public int B
        //{
        //    set
        //    {
        //        if (value != 0)
        //        {
        //            _b = value;
        //        }
        //        else
        //        {
        //            MessageBox.Show("b = 0");
        //        }
        //    }

        //    get => _b;
        //}

        public int A { get; set; }
        public int B { get; set; }

        public int Sum() => A + B;
        public int Sub() => A - B;
        public int Mult() => A * B;

        public int Div()
        {
            if (B != 0)
                return A / B;
            else
                throw new Exception("Деление на ноль");

        }

        public double Pow() => Math.Pow(A, B);
    }
}
