using System.Windows;
using MVVMCalc.Model;

namespace MVVMCalc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class CalculatorWindow : Window
    {
        public CalculatorWindow() => InitializeComponent();

        //Calculator calculator = new Calculator();

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    // Вариант 1
        //    //Result.Content =int.Parse(Number1.Text) + int.Parse(Number2.Text);

        //    // Вариант 2
        //    //Result.Content = Calculator.Sum(int.Parse(Number1.Text), int.Parse(Number2.Text));

        //    // Вариант 3
        //    //Calculator calculator = new Calculator();
        //    //Result.Content = calculator.Sum(int.Parse(Number1.Text), int.Parse(Number2.Text));

        //    // Вариант 4
        //    //calculator = new Calculator(int.Parse(Number1.Text), int.Parse(Number2.Text));
        //    //Result.Content = calculator.Sum();

        //    // Вариант 5
        //    //calculator.SetA(int.Parse(Number1.Text));
        //    //calculator.SetB(int.Parse(Number2.Text));
        //    //Result.Content = calculator.Sum();

        //    // Вариант 6
        //    calculator.AM = int.Parse(Number1.Text);
        //    calculator.B = int.Parse(Number2.Text);
        //    Result.Content = calculator.Sum();
        //}

        //private void Div_Click(object sender, RoutedEventArgs e)
        //{
        //    calculator.AM = int.Parse(Number1.Text);
        //    calculator.B = int.Parse(Number2.Text);
        //    Result.Content = calculator.Div();
        //}
    }
}