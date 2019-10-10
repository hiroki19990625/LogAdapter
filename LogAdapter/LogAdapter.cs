namespace LogAdapter
{
    public class LogAdapter : ILogAdaptor
    {
        public ILogger Create()
        {
            return new Logger();
        }
    }
}