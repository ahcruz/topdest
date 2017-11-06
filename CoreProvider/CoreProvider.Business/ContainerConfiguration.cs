using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
