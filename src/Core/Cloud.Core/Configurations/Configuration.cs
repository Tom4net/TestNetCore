using System;
namespace Cloud.Core.Configurations
{
    public class Configuration
    {
        public static Configuration Instance { get; private set; }

        private Configuration() { }

        public Configuration CreateInstance()
        {
            Instance = new Configuration();
            return Instance;
        }

        public Configuration Register<TService, TImplatement>()
        {

        }

    }
}
