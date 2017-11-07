using System.Collections.Generic;
using System.Linq;
using Autofac;
using CoreProvider.Repository;
using CoreProvider.Repository.Interface;
using CoreProvider.Services.Interface;
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

            //Providers
            builder.RegisterType<ActionTravel.Provider>().As<IProvider>();
            builder.RegisterType<Omnibees.Provider>().As<IProvider>();

            //Services
            builder.RegisterType<SearchManager>().As<ISearchManager>();
            builder.RegisterType<HotelSearchManager>().As<IHotelSearchManager>();

            //Repositories
            builder.RegisterType<HotelRepository>().As<IHotelRepository>();

            return builder.Build();
        }

        public static IList<IProvider> GetProviders()
        {
            return Container().Resolve<IEnumerable<IProvider>>().ToList();
        }
    }
}
