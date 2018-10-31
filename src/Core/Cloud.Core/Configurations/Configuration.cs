using System;
using Cloud.Core.Containers;

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
            return this;

        }

        public Configuration RegisterCommonService()
        {
            return this;
        }

        public Configuration BuildContainer()
        {
            ObjectContainer.BuildContainer();
            return this;
        }

    }
}
