using System;
using System.Collections.Generic;
//using System.Configuration;
using System.Linq;
using System.Web.Mvc;
using Moq;
using Ninject;
using FurnitureStore.Domain.Abstract;
using FurnitureStore.Domain.Concrete;
using FurnitureStore.Domain.Entities;
using FurnitureStore.WebUI.Infrastructure.Abstract;
using FurnitureStore.WebUI.Infrastructure.Concrete;



namespace FurnitureStore.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
           
            kernel.Bind<IProductsRepository>().To<EFProductRepository>();

            //EmailSettings emailSettings = new EmailSettings
            //{
            //    WriteAsFile = bool.Parse(ConfigurationManager
            //    .AppSettings["Email.WriteAsFile"] ?? "false")
            //};
            //kernel.Bind<IOrderProcessor>().To<EmailOrderProcessor>()
            //    .WithConstructorArgument("Settimgs", emailSettings);

            kernel.Bind<IAuthProvider>().To<FormsAuthProvider>();
        }
    }
}