using System.Collections.Generic;
using CoreProvider.SharedClasses.Interface;
using CoreProvider.SharedClasses.Search;
using CoreProvider.SharedClasses.Service;

namespace CoreProvider.Services
{
    public class SearchManager
    {
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

        /// <summary>
        /// Itera cada proveedor
        /// </summary>
        /// <returns></returns>
        private IList<IProvider> GetProvidersType()
        {
            return new List<IProvider>()
            {
                new ActionTravel.Provider(),
                new Omnibees.Provider()
            };
        }

        private static object GetProviderType()
        {
            string provider = "actiontravel";

            switch (provider)
            {
                case "actiontravel":
                    return new ActionTravel.Provider();
                default:
                    return null;
            }
        }
    }
}
