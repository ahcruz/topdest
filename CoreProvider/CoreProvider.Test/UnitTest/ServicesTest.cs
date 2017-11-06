using System;
using System.Collections.Generic;
using CoreProvider.Services.Interface;
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
            var moqOmnibees = new Mock<IProvider>();

            moqOmnibees.Setup(x => x.Search(new SearchData())).Returns(new List<HotelService>()
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
                    ProviderId = "Omnibees",
                    CancellationPolicies = new List<CancellationPolicy>()
                    {
                        new CancellationPolicy()
                        {
                            BeginPolicy = DateTime.Today.Date,
                            Price = 120
                        }
                    }
                }
            });

            var moqActionTravel = new Mock<IProvider>();

            moqActionTravel.Setup(x => x.Search(new SearchData())).Returns(new List<HotelService>()
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
            });

            var moqSearchManager = new Mock<ISearchManager>();
            moqSearchManager.Setup(x => x.GetProvidersType()).Returns(new List<IProvider>()
            {
                moqActionTravel.Object,
                moqOmnibees.Object
            });

            Assert.Equal(2, moqSearchManager.Object.GetSearch().Count);

        }
    }
}
