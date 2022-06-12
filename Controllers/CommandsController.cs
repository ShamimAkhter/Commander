using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MvcRestApiCore3_Commander.Data;
using MvcRestApiCore3_Commander.Models;

namespace MvcRestApiCore3_Commander.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;

        public CommandsController(ICommanderRepo repository)
        {
            _repository = repository;
        }

        // GET api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var CommandItems = _repository.GetAllCommands();

            return Ok(CommandItems);
        }

        // GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var CommandItem = _repository.GetCommandById(id);

            return Ok(CommandItem);
        }
    }
}