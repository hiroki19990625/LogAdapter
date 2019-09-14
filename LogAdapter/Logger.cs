using System;

namespace LogAdapter
{
    public class Logger : ILogger
    {
        private Action<ILogMessage> _callback = log => { };

        public void Log(string level, object data)
        {
            _callback.Invoke(new LogMessage(level, data, new object[0]));
        }

        public void Log(string level, object data, params object[] args)
        {
            _callback.Invoke(new LogMessage(level, data, args));
        }

        public void Debug(object data)
        {
            _callback.Invoke(new LogMessage("Debug", data, new object[0]));
        }

        public void Debug(object data, params object[] args)
        {
            _callback.Invoke(new LogMessage("Debug", data, args));
        }

        public void Info(object data)
        {
            _callback.Invoke(new LogMessage("Info", data, new object[0]));
        }

        public void Info(object data, params object[] args)
        {
            _callback.Invoke(new LogMessage("Info", data, args));
        }

        public void Warn(object data)
        {
            _callback.Invoke(new LogMessage("Warn", data, new object[0]));
        }

        public void Warn(object data, params object[] args)
        {
            _callback.Invoke(new LogMessage("Warn", data, args));
        }

        public void Error(object data)
        {
            _callback.Invoke(new LogMessage("Error", data, new object[0]));
        }

        public void Error(object data, params object[] args)
        {
            _callback.Invoke(new LogMessage("Error", data, args));
        }

        public void AddCallback(Action<ILogMessage> callback)
        {
            _callback += callback;
        }

        public void RemoveCallback(Action<ILogMessage> callback)
        {
            if (callback != null)
                _callback -= callback;
        }
    }
}