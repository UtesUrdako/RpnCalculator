using Calculator.Controller;
using Calculator.Interfaces;
using Calculator.Models;
using System.Windows;

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IObserver
    {
        private ICalculatorController calculatorController;
        private ICalculatorModel calculator;

        public MainWindow()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            calculator = new RpnCalculator();
            calculatorController = new RpnCalculatorController(calculator);

            calculator.RegisterObserver(this);
        }

        public void UpdateData()
        {
            lb_rpn.Content = calculator.RpnFunction;
            lb_result.Content = calculator.Result;
        }

        private void bt_calculate_Click(object sender, RoutedEventArgs e)
        {
            calculatorController.Calculate(tb_function.Text);
        }
    }
}
