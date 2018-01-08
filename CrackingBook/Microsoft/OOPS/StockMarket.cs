using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Microsoft.OOPS
{
    public interface ISubject
    {
        void Notify();
        void Register(IObserver observer);
        void UnRegister(IObserver observer);
    }

    public interface IObserver
    {
        void Update(int value);
    }

    public class StockMarket : ISubject
    {
        HashSet<IObserver> _observers;
        public void Notify()
        {
            foreach (var item in this._observers)
            {
                var randonValue = 0; //Data coming from stock market for the stock
                item.Update(randonValue);
            }
        }

        public void Register(IObserver observer)
        {
            this._observers.Add(observer);
        }

        public void UnRegister(IObserver observer)
        {
            this._observers.Remove(observer);
        }
    }

    public class Stock : IObserver
    {
        public int price { get; set; }

        public void Update(int value)
        {
            this.price = value;
        }
    }

}
