namespace LogAdapter
{
    public interface ILogMessage
    {
        string LogLevel { get; }

        object Data { get; }
        object[] Args { get; }
    }
}