using Behavioral.Observer.Implementation.Observers;
using Behavioral.Observer.Implementation.Subjects;
using Behavioral.Observer.Interfaces;

ISubscriber stockSubscriber = new StockService();
stockSubscriber.Attach(new EmailObserver());
//stockSubscriber.Attach(new NotificationObserver());

stockSubscriber.Notify("Stock Updated");

Console.WriteLine("Observer pattern demo complete.");