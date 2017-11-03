using System.Collections.Generic;
using CoreProvider.SharedClasses.Interface;
using CoreProvider.SharedClasses.Search;
using CoreProvider.SharedClasses.Service;

namespace CoreProvider.Business
{
    public class SearchManager
    {
        public IList<HotelService> GetSearch()
        {
            var at = (IProvider)GetProviderType();

            return at.Search(new SearchData());
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
