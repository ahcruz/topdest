using System.Web.Http;
using CoreProvider.Business;

namespace CoreProvider.Api.Controllers
{
    public class ProviderController : ApiController
    {
        public IHttpActionResult Get()
        {
            var searchManager = new SearchManager();

            var result = searchManager.GetSearch();

            return Ok(new { result });
        }
    }
}
