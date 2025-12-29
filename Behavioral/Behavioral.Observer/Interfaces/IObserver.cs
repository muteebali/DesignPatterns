namespace Behavioral.Observer.Interfaces
{
    internal interface IObserver
    {
        public void Update<T>(T data);
    }
}
