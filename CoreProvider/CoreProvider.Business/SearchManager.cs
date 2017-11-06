using System.Collections.Generic;
using System.Linq;
using Autofac;
using CoreProvider.Services.Interface;
using CoreProvider.SharedClasses.Interface;
using CoreProvider.SharedClasses.Search;
using CoreProvider.SharedClasses.Service;

namespace CoreProvider.Services
{
    public class SearchManager : ISearchManager
    {
        /// <summary>
        /// Contenedor de clases
        /// </summary>
        private readonly IContainer _container;

        public SearchManager()
        {
            _container = ContainerConfiguration.Container();
        }

        /// <inheritdoc />
        public IList<HotelService> GetSearch()
        {
            var providers = GetProvidersType();
            var hotelServices = new List<HotelService>();

            foreach (var provider in providers)
            {
                hotelServices.AddRange(provider.Search(new SearchData()));
            }

            return hotelServices;
        }

        /// <inheritdoc />
        public IList<IProvider> GetProvidersType()
        {
            return _container.Resolve<IEnumerable<IProvider>>().ToList();
        }
    }
}
