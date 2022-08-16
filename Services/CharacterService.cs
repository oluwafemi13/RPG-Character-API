using AutoMapper;
using Microsoft.Exchange.WebServices.Data;
using RPG_Character_API.Dtos;
using RPG_Character_API.Interfaces;
using RPG_Character_API.RPG.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_Character_API.Services
{
    public class CharacterService : ICharacterService
    {
        private readonly IMapper _mapper;
       
        private static List<Character> characters = new List<Character>()
       {
           new Character(),
           new Character
           {
               Id = 1,
               Name = "kingsley",
               Rpg = RPG.Models.RPGClass.Batman
           },
           new Character
           {
               Id = 2,
               Name = "Micheal",
               Rpg= RPG.Models.RPGClass.Arrow
           }
       };

        public CharacterService(IMapper mapper)
        {
            _mapper=mapper;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> GetAll()
        {
            ServiceResponse<List<GetCharacterDto>> serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
            serviceResponse.Data = _mapper.Map<List<GetCharacterDto>>(characters);
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetCharacterDto>> GetById(int Id)
        {
            ServiceResponse<GetCharacterDto> serviceResponse = new ServiceResponse<GetCharacterDto>();
            var result = _mapper.Map<GetCharacterDto>( characters.FirstOrDefault(x => x.Id == Id));
            serviceResponse.Data = result;
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newcharacter)
        {
            ServiceResponse<List<GetCharacterDto>> serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
            Character character = _mapper.Map<Character>( newcharacter);
            //this is for manually adding the Id since it was removed from the AddCharacterDto 
            character.Id = characters.Max(c=>c.Id)+1;
            //characters.Add(_mapper.Map<Character>(newcharacter));
            serviceResponse.Data = (characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList());
            return serviceResponse;
        }
    }

}
