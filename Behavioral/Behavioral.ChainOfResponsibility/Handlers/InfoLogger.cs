namespace Behavioral.ChainOfResponsibility.Handlers
{
    internal class InfoLogger : Logger
    {
        public override void HandleRequest(int value)
        {
            if (value > 0)
            {
                Console.WriteLine($"Info: {value}");
            }
            else
            {
                Next?.HandleRequest(value);
            }
        }
    }
}
