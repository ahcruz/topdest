using System;
using System.Collections.Generic;
using CoreProvider.SharedClasses;
using CoreProvider.SharedClasses.Interface;
using CoreProvider.SharedClasses.Service;

namespace CoreProvider.Test.Common
{
    public static class ServiceUtils
    {
        /// <summary>        
        /// Genera una lista servicios de hoteles
        /// </summary>
        /// <returns></returns>
        public static List<HotelService> HotelServices()
        {
            return new List<HotelService>()
            {
                new HotelService()
                {
                    BeginService = DateTime.Today,
                    EndService = DateTime.Today.AddDays(5),
                    Occupancy = new Occupancy() {Adults = 2},
                    Price = 150.75,
                    Room = new Room() { Description = "Habitacion doble"},
                    Supplements = new List<Supplement>()
                    {
                        new Supplement()
                        {
                            Type = SupplementEnum.Included,
                            Description = "All Inclusive",
                            Price = 50
                        }
                    },
                    ProviderId = "Action Travel",
                    CancellationPolicies = new List<CancellationPolicy>()
                    {
                        new CancellationPolicy()
                        {
                            BeginPolicy = DateTime.Today.Date,
                            Price = 120
                        }
                    }
                }
            };
        }
    }
}
