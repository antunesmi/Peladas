using Microsoft.AspNetCore.Mvc;

namespace Pelada_WEBAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeladaController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
        return Ok("Omega Rugal");
        }

    }
}