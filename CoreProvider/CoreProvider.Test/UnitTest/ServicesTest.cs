using System;
using System.Collections.Generic;
using CoreProvider.Services;
using CoreProvider.SharedClasses.Interface;
using CoreProvider.SharedClasses.Search;
using CoreProvider.Test.Common;
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

            moqActionTravel.Setup(x => x.Search(It.IsAny<SearchData>())).Returns(ServiceUtils.HotelServices());

            var moqSearchManager = new Mock<SearchManager>(new List<IProvider>
            {
                moqActionTravel.Object
            })
            {
                CallBase = true
            };

            Assert.Equal(1, moqSearchManager.Object.GetSearch().Count);

        }

        [Fact]
        public void Search_error_exception_no_services()
        {
            var moqActionTravel = new Mock<ActionTravel.Provider>().As<IProvider>();
            moqActionTravel.CallBase = true;

            moqActionTravel.Setup(x => x.Search(It.IsAny<SearchData>())).Throws(new Exception("Error"));

            var moqSearchManager = new Mock<SearchManager>(new List<IProvider>
            {
                moqActionTravel.Object
            })
            {
                CallBase = true
            };

            Assert.Throws<Exception>(() => moqSearchManager.Object.GetSearch());
        }

        [Fact]
        public void Search_lauch_exception_with_services()
        {
            var provider1 = new Mock<ActionTravel.Provider>().As<IProvider>();
            provider1.CallBase = true;

            provider1.Setup(x => x.Search(It.IsAny<SearchData>())).Throws(new Exception("Error"));

            var provider2 = new Mock<ActionTravel.Provider>().As<IProvider>();
            provider2.CallBase = true;

            provider2.Setup(x => x.Search(It.IsAny<SearchData>())).Returns(ServiceUtils.HotelServices());

            var moqSearchManager = new Mock<SearchManager>(new List<IProvider>
            {
                provider1.Object,
                provider2.Object
            })
            {
                CallBase = true
            };

            Assert.Equal(1, moqSearchManager.Object.GetSearch().Count);
        }
    }
}
