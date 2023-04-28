using Calculator.Interfaces;

namespace Calculator.Controller
{
    internal class RpnCalculatorController : ICalculatorController
    {
        private ICalculatorModel calculator;

        public RpnCalculatorController(ICalculatorModel calculator)
        {
            this.calculator = calculator;
        }

        public void Calculate(string function)
        {
            calculator.Calculate(function);
        }
    }
}
