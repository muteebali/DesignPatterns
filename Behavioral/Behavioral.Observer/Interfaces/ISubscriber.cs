namespace Behavioral.Observer.Interfaces
{
    internal interface ISubscriber
    {
        public void Attach(IObserver observer);
        public void Dettach(IObserver observer);
        public void Notify<T>(T data);
    }
}
