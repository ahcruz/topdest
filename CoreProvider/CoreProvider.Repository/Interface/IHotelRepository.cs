using System.Collections.Generic;
using System.Threading.Tasks;
using CoreProvider.Domain;

namespace CoreProvider.Repository.Interface
{
    public interface IHotelRepository : IRepository<Hotel>
    {
        Task<IList<Hotel>> GetHotelByNameAsync(string name);
    }
}
