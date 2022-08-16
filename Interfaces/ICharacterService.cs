using RPG_Character_API.Dtos;
using RPG_Character_API.RPG.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RPG_Character_API.Interfaces
{
    public interface ICharacterService
    {

        //Characters GetOne();

       Task<ServiceResponse<List<GetCharacterDto>>> GetAll();

        Task<ServiceResponse<GetCharacterDto>> GetById(int id);

        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newcharacter);
    }
}
