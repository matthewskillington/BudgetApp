using System;
using Autofac;
using BudgetApp.Services;
using BudgetApp.ViewModels;

namespace BudgetApp.Bootstrap
{
    public static class AppContainer
    {
        private static IContainer _container;

        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            //ViewModels
            builder.RegisterType<NamePageViewModel>();

            //Services
            builder.RegisterType<NavigationService>().As<INavigationService>();

            _container = builder.Build();
        }

        public static object Resolve (Type typeName)
        {
            return _container.Resolve(typeName);
        }

        public static T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
