using Autofac;
using MinistryApp.Interfaces;
using MinistryApp.Repositories;
using MinistryApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinistryApp.Bootstrapping
{
    public class AppContainer
    {
        private static IContainer _container;

        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ServiceRepository>().As<IServiceRepository>();
            builder.RegisterType<HomeViewModel>();


            _container = builder.Build();
        }

        public static object Resolve(Type typeName)
        {
            return _container.Resolve(typeName);
        }

        public static T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
