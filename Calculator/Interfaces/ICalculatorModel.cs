namespace Calculator.Interfaces
{
    public interface ICalculatorModel : IObservable
    {
        void Calculate(string function);
        string RpnFunction { get; }
        string Result { get; }
    }
}
