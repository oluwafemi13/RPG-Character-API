using AutoMapper;
using RPG_Character_API.Dtos;
using RPG_Character_API.RPG.Models;

namespace RPG_Character_API.mappings
{
    public class mappings:Profile
    {

        public mappings()
        {
            CreateMap<Character, AddCharacterDto>().ReverseMap();
            CreateMap<Character, GetCharacterDto>().ReverseMap();
        }
    }
}
