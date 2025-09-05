using Microsoft.AspNetCore.Mvc;
namespace ProductServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProduct()
        {
            return Ok();
        }
    }
}
