using System;
namespace Cloud.Core.Logs
{
    public interface ILogger
    {
        void Debug(object message);
        void Debug(object message,Exception e);

        void DebugFormat(string formatStr,params object[] args);

        void Info(object message);
        void Info(object message,Exception e);

        void InfoFormat(string formatStr,params object[] args);

        void Wain(object message);
        void Wain(object message,Exception e);

        void WainFormat(string formatStr,params object[] args);

        void Error(object message);
        void Error(object message,Exception e);

        void ErrorFormat(string formatStr,params object[] args);

        void Fatal(object message);

        void Fatil(object message);

        void FatalFormat(string formatStr,params object[] args);

    }

    public enum LogLevel
    {
        Debug = 1,
        Info = 2,
        Warn = 3,
        Error = 4,
        Fatal = 5

    }
}