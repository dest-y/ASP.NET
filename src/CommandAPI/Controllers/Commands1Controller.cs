using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
namespace CommandAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Commands1Controller : ControllerBase
    {
        [HttpPost]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "this", "is", " not hard", "coded" };
        }
    }
}