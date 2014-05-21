namespace AirlinesDemo.Infrastracture
{
    using System.Web.Http.Dependencies;
    using Ninject;
    using IDependencyResolver = System.Web.Mvc.IDependencyResolver;

    public class NinjectResolver: NinjectScope, IDependencyResolver
    {
        private readonly IKernel _kernel;

        public NinjectResolver(IKernel kernel) : 
            base(kernel)
        {
            _kernel = kernel;
        }

        public IDependencyScope BeginScope()
        {
            return new NinjectScope(_kernel);
        }
    }
}