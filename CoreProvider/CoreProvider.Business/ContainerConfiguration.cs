using System.Collections.Generic;
using System.Linq;
using Autofac;
using CoreProvider.SharedClasses.Interface;

namespace CoreProvider.Services
{
    public static class ContainerConfiguration
    {
        /// <summary>
        /// Contenedor de dependecias
        /// </summary>
        /// <returns></returns>
        public static IContainer Container()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ActionTravel.Provider>().As<IProvider>();
            builder.RegisterType<Omnibees.Provider>().As<IProvider>();

            return builder.Build();
        }

        public static IList<IProvider> GetProviders()
        {
            return Container().Resolve<IEnumerable<IProvider>>().ToList();
        }
    }
}
