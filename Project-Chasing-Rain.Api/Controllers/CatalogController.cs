using Microsoft.AspNetCore.Mvc;
using Project.Chasing.Rain.Domain.Catalog;

namespace Project.Chasing.Rain.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetItems()
        {
            return Ok("hello world.");
        }
    }
}