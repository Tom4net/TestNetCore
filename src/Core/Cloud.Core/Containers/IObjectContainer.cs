using System;
namespace Cloud.Core.Containers
{
    public interface IObjectContainer
    {
        void Build();

        void TypeRegister(Type implatementType, LifeCircle life = LifeCircle.Singleton);

        void TypeRegister(Type implatementType, Type serviceType, LifeCircle life = LifeCircle.Singleton);

        void TypeRegister<TService, TImplatement>(Type implatementType, Type serviceType, LifeCircle life = LifeCircle.Singleton)
            where TService : class
            where TImplatement : class;
        void InstanceRegister<TService, TImplatement>(TImplatement implatement, LifeCircle life = LifeCircle.Singleton)
            where TService : class
            where TImplatement : class;

        TImplatement Resolve<TService>()
            where TService : class;
        object Resolve(Type serviceType);
        bool TryResolve<TService>(out TService instance) where TService : class;
        
        bool TryResolve(Type serviceType, out object instance);
    }
}