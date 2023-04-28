using Calculator.Interfaces;
using System.Collections.Generic;

namespace Calculator.Models
{
    // Библиотека работает с одноразрядными числами и с опрераторами +, -, *, /, ^ и со скобками
    // Не реализовано вычисление с отрицательными и не целыми числами
    internal class RpnCalculator : RpnCalculate.RpnCalculator, ICalculatorModel
    {
        private List<IObserver> observers = new List<IObserver>();

        // Переопределяется функция Calculate для добавления оповещения наблюдателей
        public new void Calculate(string function)
        {
            base.Calculate(function);
            NotifyObservers();
        }

        public void RegisterObserver(IObserver o)
        {
            if (!observers.Contains(o))
                observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            if (observers.Contains(o))
                observers.Remove(o);
        }

        public void NotifyObservers()
        {
            observers.ForEach(observer => observer.UpdateData());
        }
    }
}
