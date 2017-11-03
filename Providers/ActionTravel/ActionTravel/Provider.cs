using System;
using System.Collections.Generic;
using CoreProvider.SharedClasses;
using CoreProvider.SharedClasses.Interface;
using CoreProvider.SharedClasses.Search;
using CoreProvider.SharedClasses.Service;

namespace ActionTravel
{
    public class Provider : IProvider
    {
        IList<HotelService> IProvider.Search(SearchData data)
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
                    ProviderId = "Estas en un hotel de action travel"
                },
                new HotelService()
                {
                    BeginService = DateTime.Today.AddDays(-5),
                    EndService = DateTime.Today.AddDays(10)
                }
            };
        }
    }
}
