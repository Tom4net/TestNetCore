using System;
namespace Cloud.Core.Containers
{

    public class ObjectContainer
    {
        public static IObjectContainer Current { get; private set; }

        private ObjectContainer() { }
        public static SetObjectContainer(IObjectContainer objectcontainer)
        {
            Current = objectcontainer;
        }
    }
}