using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CommandAPI.Data;
using CommandAPI.Models;

namespace CommandAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController: ControllerBase
    {
        private readonly ICommandAPIRepo _repository;

        public CommandsController(ICommandAPIRepo repositry)
        {
            _repository = repositry;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();
            return Ok(commandItems);
        }

        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);
            if(commandItem == null)
            {
                return NotFound();
            }
            return Ok(commandItem);
        }


        // [HttpGet]
        // [HttpPost]
        // public ActionResult<IEnumerable<string>> Get()
        // {
        //     if(Request.Method.Equals("GET")){
        //         return new string[]{ "HttpMethod", "GET", "this", "is", "hard", "coded"};
        //     }
        //     else{
        //         return new string[]{ "HttpMethod", "POST", "this", "is", "hard", "coded"};
        //     }
        // }
    }
}