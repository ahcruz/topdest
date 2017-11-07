using System;
using System.Threading.Tasks;
using System.Web.Http;
using Autofac;
using CoreProvider.Services;
using CoreProvider.Services.Interface;

namespace CoreProvider.Api.Controllers
{
    public class ProviderController : ApiController
    {
        private readonly IContainer _container;

        public ProviderController()
        {
            _container = ContainerConfiguration.Container();
        }

        /// <summary>
        /// Busca disponibilidad de hoteles dado un lista
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IHttpActionResult> Search()
        {
            var searchManager = _container.Resolve<ISearchManager>();

            try
            {
                var result = searchManager.GetSearch();
                return await Task.FromResult(Ok(new { result }));
            }
            catch (Exception e)
            {
                return await Task.FromResult(BadRequest(e.Message));
            }
        }
    }
}
