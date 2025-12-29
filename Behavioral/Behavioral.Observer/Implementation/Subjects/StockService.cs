using Behavioral.Observer.Interfaces;

namespace Behavioral.Observer.Implementation.Subjects
{
    internal class StockService : ISubscriber
    {
        private List<IObserver>? _observers { get; set; } = new();

        public void Attach(IObserver observer)
        {
            _observers?.Add(observer);
        }

        public void Dettach(IObserver observer)
        {
            _observers?.Remove(observer);
        }

        public void Notify<T>(T data)
        {
            foreach (var obs in _observers!)
            {
                obs.Update(data);
            }
        }
    }
}
