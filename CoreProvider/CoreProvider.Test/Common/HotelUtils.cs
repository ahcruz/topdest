using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreProvider.Domain;

namespace CoreProvider.Test.Common
{
    public static class HotelUtils
    {
        public static IList<Hotel> Hotels()
        {
            return new List<Hotel>()
            {
                new Hotel()
                {
                    Provider = "test",
                    Address = "Rondeau 252",
                    Id = 1,
                    Name = "Club Hotel Prueba 1"
                },
                new Hotel()
                {
                    Provider = "test",
                    Address = "Rondeau 111",
                    Id = 2,
                    Name = "Hotel Resort Prueba 2"
                },
                new Hotel()
                {
                    Provider = "test",
                    Address = "Rondeau 111",
                    Id = 3,
                    Name = "Grand Hotel Prueba 3"
                }
            };
        }
    }
}
