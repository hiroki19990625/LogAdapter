namespace LogAdapter
{
    public class LogAdapter
    {
        ILogger Create()
        {
            return new Logger();
        }
    }
}