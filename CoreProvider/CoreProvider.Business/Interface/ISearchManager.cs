using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreProvider.SharedClasses.Interface;
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

        /// <summary>
        /// Itera cada proveedor
        /// </summary>
        /// <returns></returns>
        IList<IProvider> GetProvidersType();
    }
}
