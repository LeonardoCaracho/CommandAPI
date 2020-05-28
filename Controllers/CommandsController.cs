using System.Collections.Generic;
using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    // ->  api/commands
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase 
    {
        private readonly MockCommanderRepo _repository = new MockCommanderRepo();

        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            return Ok(_repository.GetAppCommands());
        }

        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            return Ok(_repository.GetCommandById(id));
        }
    }
}