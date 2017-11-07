using System.Collections.Generic;
using System.Threading.Tasks;
using CoreProvider.Domain;

namespace CoreProvider.Services.Interface
{
    public interface IHotelSearchManager
    {
        /// <summary>
        /// Retorna hoteles por nombre
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<List<Hotel>> SearchHotelByName(string name);
    }
}
