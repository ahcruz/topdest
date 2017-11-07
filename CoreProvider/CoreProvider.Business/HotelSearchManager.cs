using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreProvider.Domain;
using CoreProvider.Repository.Interface;
using CoreProvider.Services.Interface;

namespace CoreProvider.Services
{
    public class HotelSearchManager : IHotelSearchManager
    {
        private readonly IHotelRepository _hotelRepository;

        public HotelSearchManager(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        /// <inheritdoc />
        public async Task<List<Hotel>> SearchHotelByName(string name)
        {
            var hotels = await _hotelRepository.GetHotelByNameAsync(name);

            return await Task.FromResult(hotels.ToList());
        }
    }
}
