using CoreProvider.SharedClasses.Interface;
using CoreProvider.SharedClasses.Search;
using CoreProvider.Test.Common;
using Moq;
using Xunit;

namespace CoreProvider.Test.UnitTest
{
    public class ApiTest
    {
        [Fact]
        public void Search_good_request()
        {
            var moqActionTravel = new Mock<ActionTravel.Provider>().As<IProvider>();
            moqActionTravel.CallBase = true;

            moqActionTravel.Setup(x => x.Search(It.IsAny<SearchData>())).Returns(ServiceUtils.HotelServices());
        }
    }
}
