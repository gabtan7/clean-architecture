using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("[controller]")]
    public class DinnersController : ApiController
    {
        [HttpGet]
        public IActionResult ListDinners()
        {
            return Ok(Array.Empty<string>());
        }
    }
}
