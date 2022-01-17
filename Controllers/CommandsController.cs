using System.Collections.Generic;
using AutoMapper;
using Commander.Data;
using Commander.Dtos;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace  Commander.Controllers
{
    [Route("api/commands")]
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
        //GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<CommandReadDto>> GetAllCommands()
        {
            var result = _repository.GetAllCommands();
            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(result));
        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <CommandReadDto> GetCommandById(int id)
        {
            var result = _repository.GetCommandById(id);
            if(result != null)
            {
                return Ok(_mapper.Map<CommandReadDto>(result));
            }
            return NotFound();
        }
     }
}