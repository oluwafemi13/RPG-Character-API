using RPG_Character_API.RPG.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RPG_Character_API.Interfaces
{
    public interface ICharacterService
    {

        //Characters GetOne();

       Task<ServiceResponse<List<Characters>>> GetAll();

        Task<ServiceResponse<Characters>> GetById(int id);

        Task<ServiceResponse<List<Characters>>> AddCharacter(Characters newcharacter);
    }
}
