namespace AirlinesDemo.Infrastracture
{
    using System;
    using System.Collections.Generic;
    using System.Web.Http.Dependencies;
    using Ninject;

    public class NinjectScope: IDependencyScope
    {
        private IKernel _kernel;

        public NinjectScope(IKernel kernel)
        {
            _kernel = kernel;
        }

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return _kernel.GetAll(serviceType);
            }
            catch (Exception)
            {
                return new List<object>();
            }
        }

        public void Dispose()
        {
            IDisposable disposable = _kernel;

            if (disposable != null)
            {
                disposable.Dispose();
            }

            _kernel = null;
        }
    }
}