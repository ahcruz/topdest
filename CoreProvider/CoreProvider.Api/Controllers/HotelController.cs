using System.Threading.Tasks;
using System.Web.Http;
using Autofac;
using CoreProvider.Services;
using CoreProvider.Services.Interface;

namespace CoreProvider.Api.Controllers
{
    public class HotelController : ApiController
    {
        private readonly IHotelSearchManager _hotelSearchManager = ContainerConfiguration.Container().Resolve<IHotelSearchManager>();

        public async Task<IHttpActionResult> GetHotelByName(string name)
        {
            var hotel = await _hotelSearchManager.SearchHotelByName(name);

            return await Task.FromResult(Ok(new { hotel }));
        }
    }
}
