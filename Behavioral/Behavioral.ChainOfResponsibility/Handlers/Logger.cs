namespace Behavioral.ChainOfResponsibility.Handlers
{
    internal abstract class Logger
    {
        protected Logger? Next;
        public void SetNextLogger(Logger next)
        {
            Next = next;
        }
        public abstract void HandleRequest(int value);
    }
}
