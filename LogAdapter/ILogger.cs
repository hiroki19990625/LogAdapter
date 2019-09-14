using System;

namespace LogAdapter
{
    public interface ILogger
    {
        void Log(string level, object data);
        void Log(string level, object data, params object[] args);

        void Debug(object data);
        void Debug(object data, params object[] args);
        void Info(object data);
        void Info(object data, params object[] args);
        void Warn(object data);
        void Warn(object data, params object[] args);
        void Error(object data);
        void Error(object data, params object[] args);

        void AddCallback(Action<ILogMessage> callback);
        void RemoveCallback(Action<ILogMessage> callback);
    }
}