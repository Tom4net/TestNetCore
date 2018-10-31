using System;
namespace Cloud.Core.Containers
{

    public class ObjectContainer
    {
        public static IObjectContainer Current { get; private set; }

        private ObjectContainer() { }
        public static void SetObjectContainer(IObjectContainer objectcontainer)
        {
            Current = objectcontainer;
        }

        public static void BuildContainer()
        {
            Current.Build();
        }
    }


}