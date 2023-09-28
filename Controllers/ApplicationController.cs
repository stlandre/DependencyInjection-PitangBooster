using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pitang.booster.dependency.injection._1._2.IBusiness;

namespace pitang.booster.dependency.injection._1._2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private readonly IApplicationBusiness _applicationBusiness;
        public ApplicationController(IApplicationBusiness applicationBusiness)
        {
            _applicationBusiness = applicationBusiness;
        }

        [HttpGet]
        [Route("retornarServicos")]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        public IActionResult RetornarServicos()
        {
            var requisicao = _applicationBusiness.RetornoApplication();

            return Ok(requisicao);
        }
    }
}
