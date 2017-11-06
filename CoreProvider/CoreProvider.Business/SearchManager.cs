using System.Collections.Generic;
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
        private readonly IList<IProvider> _providers;

        public SearchManager()
        {
            _providers = ContainerConfiguration.GetProviders();
        }

        public SearchManager(IList<IProvider> providers)
        {
            _providers = providers;
        }

        /// <inheritdoc />
        public IList<HotelService> GetSearch()
        {
            var hotelServices = new List<HotelService>();

            foreach (var provider in _providers)
            {
                hotelServices.AddRange(provider.Search(new SearchData()));
            }

            return hotelServices;
        }
    }
}
