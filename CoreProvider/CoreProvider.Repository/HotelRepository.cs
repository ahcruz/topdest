using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CoreProvider.Domain;
using CoreProvider.Repository.Interface;

namespace CoreProvider.Repository
{
    public class HotelRepository : IHotelRepository
    {
        public IEnumerable<Hotel> List { get; }
        public void Add(Hotel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Hotel entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Hotel entity)
        {
            throw new NotImplementedException();
        }

        public Hotel FindById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Hotel>> GetHotelByNameAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}
