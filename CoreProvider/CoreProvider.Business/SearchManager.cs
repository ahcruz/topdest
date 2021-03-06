﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreProvider.Domain;
using CoreProvider.Services.Interface;
using CoreProvider.SharedClasses.Interface;
using CoreProvider.SharedClasses.Search;
using CoreProvider.SharedClasses.Service;

namespace CoreProvider.Services
{
    public class SearchManager : ISearchManager
    {
        /// <summary>
        /// Lista de proveedores activos
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
                try
                {
                    hotelServices.AddRange(provider.Search(new SearchData()));
                }
                catch (Exception e)
                {
                    //TODO Ver de logear el error                    
                }
            }

            if (hotelServices.Any()) return hotelServices;

            throw new Exception("No se encontraron hoteles");
        }
    }
}
