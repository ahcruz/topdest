﻿using System.Collections.Generic;
using System.Threading.Tasks;
using CoreProvider.Domain;
using CoreProvider.SharedClasses.Service;

namespace CoreProvider.Services.Interface
{
    public interface ISearchManager
    {
        /// <summary>
        /// Obtiene search
        /// </summary>
        /// <returns></returns>
        IList<HotelService> GetSearch();
    }
}
