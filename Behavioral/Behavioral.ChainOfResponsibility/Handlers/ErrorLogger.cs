namespace Behavioral.ChainOfResponsibility.Handlers
{
    internal class ErrorLogger : Logger
    {
        public override void HandleRequest(int value)
        {
            Console.WriteLine($"Error: {value}");
        }
    }
}
