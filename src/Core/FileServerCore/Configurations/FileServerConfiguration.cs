using System;

namespace FileServerCore.Configurations
{
    public class FileServerConfiguration
    {
        public static FileServerConfiguration Instance
        {
            private set;
            get;
        }

        private FileServerConfiguration() { }

        public static FileServerConfiguration Create()
        {
            Instance = new FileServerConfiguration();
            return Instance;
        }

    }
}
