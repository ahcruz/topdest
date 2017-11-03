using System.Collections.Generic;
using CoreProvider.SharedClasses.Search;
using CoreProvider.SharedClasses.Service;

namespace CoreProvider.SharedClasses.Interface
{
    /// <summary>
    /// Interfaz a implementar por todos los proveedores
    /// </summary>
    public interface IProvider
    {
        /// <summary>
        /// Realiza busqueda
        /// </summary>
        /// <param name="data">Objeto que contiene elementos necesarios para poder realizar busqueda</param>
        IList<HotelService> Search(SearchData data);
    }
}
