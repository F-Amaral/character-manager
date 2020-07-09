using CharacterManager.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CharacterManager.APP.Controllers.V1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CharactersController : ControllerBase
    {
        [HttpGet]
        public IActionResult Create()
        {
            var character = new Character(Race.Human, Class.Barbarian);
            return Created("api/v1/characters", character);
        }
    }
}