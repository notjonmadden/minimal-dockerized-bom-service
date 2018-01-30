using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MinimalDockerizedBomService.Controllers
{
    [Route("[controller]")]
    public class AssembliesController : Controller
    {
        [HttpGet("{partNumber}")]
        public ActionResult Get(string partNumber)
        {
            if ("E11401906".Equals(partNumber))
            {
                return Ok(new { Description = "VALVE" });
            }

            return NotFound();
        }
    }
}
