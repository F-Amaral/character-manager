using System.Linq;
using CharacterManager.APP.Mappers.CommandMappers;
using CharacterManager.Application.Interfaces;
using CharacterManager.Application.Services;
using CharacterManager.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CharacterManager.APP.Controllers.V1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CharactersController : ControllerBase
    {
        public readonly ICharacterLevelUpper CharacterLevelUpper;
        public readonly CommandToCommandDTOMapper CommandToCommandDtoMapper;
        public CharactersController(ICharacterLevelUpper characterLevelUpper, CommandToCommandDTOMapper mapper)
        {
            CharacterLevelUpper = characterLevelUpper;
            CommandToCommandDtoMapper = mapper;
        }
        
        [HttpGet]
        public IActionResult GetCommandLevelUp()
        {
            var character = new Character(FeatureType.Human, FeatureType.Fighter);
            var commands = CharacterLevelUpper.GetCommands(character);
            return Created("api/v1/characters/level-up", commands.Select(x => CommandToCommandDtoMapper.Map(x)));
        }
    }
}