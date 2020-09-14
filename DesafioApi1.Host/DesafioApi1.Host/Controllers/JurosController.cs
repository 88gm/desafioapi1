using DesafioApi1.Domain.Juros;
using Microsoft.AspNetCore.Mvc;

namespace DesafioApi1.Host.Controllers
{
    [Route("api/juros")]
    [ApiController]
    public class JurosController : ControllerBase
    {
        public JurosController() { }

        [HttpGet]
        [Route("taxa")]
        public IActionResult Taxa()
        {
            return Ok(new Juros());
        }
    }
}