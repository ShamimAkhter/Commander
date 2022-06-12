using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MvcRestApiCore3_Commander.Data;
using MvcRestApiCore3_Commander.Models;
using MvcRestApiCore3_Commander.Dtos;

namespace MvcRestApiCore3_Commander.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;
        private readonly IMapper _mapper;

        public CommandsController(ICommanderRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET api/commands
        [HttpGet]
        public ActionResult<IEnumerable<CommandReadDtos>> GetAllCommands()
        {
            var CommandItems = _repository.GetAllCommands();

            return Ok(_mapper.Map<IEnumerable<CommandReadDtos>>(CommandItems));
        }

        // GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult<CommandReadDtos> GetCommandById(int id)
        {
            var CommandItem = _repository.GetCommandById(id);
            if (CommandItem != null)
            {
                return Ok(_mapper.Map<CommandReadDtos>(CommandItem));
            }
            return NotFound();
        }
    }
}