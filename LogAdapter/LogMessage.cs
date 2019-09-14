namespace LogAdapter
{
    public class LogMessage : ILogMessage
    {
        public string LogLevel { get; }

        public object Data { get; }
        public object[] Args { get; }

        public LogMessage(string logLevel, object data, object[] args)
        {
            LogLevel = logLevel;
            Data = data;
            Args = args;
        }
    }
}