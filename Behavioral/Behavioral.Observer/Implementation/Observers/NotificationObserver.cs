using Behavioral.Observer.Interfaces;

namespace Behavioral.Observer.Implementation.Observers
{
    internal class NotificationObserver : IObserver
    {
        public void Update<T>(T data)
        {
            Console.WriteLine("NotificationObserver: Sending notification..." + data);
        }
    }
}
