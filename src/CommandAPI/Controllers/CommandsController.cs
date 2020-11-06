using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CommandAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController: ControllerBase
    {
        [HttpGet]
        [HttpPost]
        public ActionResult<IEnumerable<string>> Get()
        {
            if(Request.Method.Equals("GET")){
                return new string[]{ "HttpMethod", "GET", "this", "is", "hard", "coded"};
            }
            else{
                return new string[]{ "HttpMethod", "POST", "this", "is", "hard", "coded"};
            }
        }
    }
}