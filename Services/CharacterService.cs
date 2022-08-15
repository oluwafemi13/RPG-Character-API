using Microsoft.Exchange.WebServices.Data;
using RPG_Character_API.Interfaces;
using RPG_Character_API.RPG.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_Character_API.Services
{
    public class CharacterService : ICharacterService
    {
       
        private static List<Characters> characters = new List<Characters>()
       {
           new Characters(),
           new Characters
           {
               Id = 1,
               Name = "kingsley",
               Rpg = RPGClass.Batman
           },
           new Characters
           {
               Id = 2,
               Name = "Micheal",
               Rpg=RPGClass.Arrow
           }
       };

       

        public async Task<ServiceResponse<List<Characters>>> GetAll()
        {
            ServiceResponse<List<Characters>> serviceResponse = new ServiceResponse<List<Characters>>();
            serviceResponse.Data = characters;
            return serviceResponse;
        }

        public async Task<ServiceResponse<Characters>> GetById(int Id)
        {
            ServiceResponse<Characters> serviceResponse = new ServiceResponse<Characters>();
            var result = characters.FirstOrDefault(x => x.Id == Id);
            serviceResponse.Data = result;
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Characters>>> AddCharacter(Characters newcharacter)
        {
            ServiceResponse<List<Characters>> serviceResponse = new ServiceResponse<List<Characters>>();
            characters.Add(newcharacter);
            serviceResponse.Data = characters;
            return serviceResponse;
        }
    }

}
