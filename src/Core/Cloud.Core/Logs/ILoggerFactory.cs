using System;

namespace Cloud.Core.Logs
{
    public interface ILoggerFactory
    {
        ILogger Create(string name);

        ILogger Create (Type type);
    }
}