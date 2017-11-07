using System;
using System.Threading.Tasks;
using System.Web.Http;
using Autofac;
using CoreProvider.Api.Model;
using CoreProvider.Services;
using CoreProvider.Services.Interface;

namespace CoreProvider.Api.Controllers
{
    public class HotelController : ApiController
    {
        private readonly IHotelSearchManager _hotelSearchManager = ContainerConfiguration.Container().Resolve<IHotelSearchManager>();

        [HttpGet]
        public async Task<IHttpActionResult> GetByName(string name)
        {
            var response = new Response();

            try
            {
                if (name.Length > 3)
                {
                    var hotels = await _hotelSearchManager.SearchHotelByName(name);
                    response.Result = hotels;
                }

                response.Status = StatusEnum.Ok;
            }
            catch (Exception e)
            {
                response.Status = StatusEnum.Error;
                response.ErrorMessage = e.Message;
            }


            response.Date = DateTime.Now;
            return await Task.FromResult(Ok(new { response }));
        }
    }
}
