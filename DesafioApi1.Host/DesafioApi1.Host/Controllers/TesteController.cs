using Microsoft.AspNetCore.Mvc;

namespace DesafioApi1.Host.Controllers
{
    [Route("api/teste")]
    [ApiController]
    public class TesteController : ControllerBase
    {
        public TesteController() { }

        [HttpPost]
        [Route("get")]
        public IActionResult endpoint()
        {
            return Ok(new { response = "Testado com sucesso."});
        }
    }
}
