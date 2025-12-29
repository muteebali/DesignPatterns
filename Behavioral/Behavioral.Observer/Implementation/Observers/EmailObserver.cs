using Behavioral.Observer.Interfaces;

namespace Behavioral.Observer.Implementation.Observers
{
    internal class EmailObserver : IObserver
    {
        public void Update<T>(T data)
        {
            Console.WriteLine("EmailObserver: Sending email notification..." + data);
        }
    }
}
