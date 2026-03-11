using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiClass.Filters;

namespace WebApiClass.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
     
    public class TestFilterController : ControllerBase
    {
        [HttpGet]
        [ResourceFilter]
        [AuthFilter2]
        [Actionfilter]
        [ResultFilter]
        public   IActionResult Get()
        {
            Console.WriteLine("test It Action");

            return Ok("test It......");
        }
    }
}
