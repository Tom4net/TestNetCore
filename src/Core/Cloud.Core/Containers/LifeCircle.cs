using System;
namespace Cloud.Core.Containers
{

    public enum LifeCircle
    {
        /// <summary>
        /// 每次调用生成一个新的对象
        /// </summary>
        Transient,
        /// <summary>
        /// 单例，每次调用同一实例
        /// </summary>
        Singleton
    }
}
