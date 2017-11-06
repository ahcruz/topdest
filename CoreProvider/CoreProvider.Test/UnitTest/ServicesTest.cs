using System;
using System.Collections.Generic;
using CoreProvider.Services;
using CoreProvider.SharedClasses;
using CoreProvider.SharedClasses.Interface;
using CoreProvider.SharedClasses.Search;
using CoreProvider.SharedClasses.Service;
using Moq;
using Xunit;

namespace CoreProvider.Test.UnitTest
{
    public class ServicesTest
    {
        [Fact]
        public void Search_success_with_services()
        {
            var moqActionTravel = new Mock<ActionTravel.Provider>().As<IProvider>();
            moqActionTravel.CallBase = true;

            moqActionTravel.Setup(x => x.Search(It.IsAny<SearchData>())).Returns(HotelServices());

            var moqSearchManager = new Mock<SearchManager>(new List<IProvider>
            {
                moqActionTravel.Object
            })
            {
                CallBase = true
            };

            Assert.Equal(1, moqSearchManager.Object.GetSearch().Count);

        }

        /// <summary>        
        /// Genera una lista servicios de hoteles
        /// </summary>
        /// <returns></returns>
        private static List<HotelService> HotelServices()
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
