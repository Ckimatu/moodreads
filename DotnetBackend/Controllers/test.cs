using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotnetBackend.Controllers
{
    [ApiController]
    [Route("/")]
    public class test : ControllerBase 
    {
        [HttpGet]
        public IActionResult Get()
    {
        return Ok("In the end, all we really have is each other.   - Mr. Robot" );
        
    }
}
}