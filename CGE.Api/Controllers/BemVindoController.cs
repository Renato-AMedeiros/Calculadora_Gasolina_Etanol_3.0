using Microsoft.AspNetCore.Mvc;

namespace CGE.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BemVindoController : ControllerBase
    {
        [HttpGet("DarOi")]
        public IActionResult DarOi()
        {
            //return Unauthorized();
            return Ok("Bem vindo");
        }

        [HttpGet("DarTchau")]
        public IActionResult DarTchau()
        {
            return Unauthorized();
            //return Ok("Bem vindo");
        }
    }
}
