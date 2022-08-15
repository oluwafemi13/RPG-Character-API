using Microsoft.AspNetCore.Mvc;
using RPG_Character_API.Interfaces;
using RPG_Character_API.RPG.Models;
using RPG_Character_API.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_Character_API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _characterService.GetAll());
        }


        [HttpGet("{Id}")]
        public async Task<IActionResult> GetbyId(int Id)
        {
           return Ok(await _characterService.GetById(Id));
        }

        [HttpPost]
        public async Task<IActionResult> AddCharacter(Characters newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }


    }
}
