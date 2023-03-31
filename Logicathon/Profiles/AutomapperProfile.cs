using AutoMapper;
using Logicathon.Models.Domain;
using Logicathon.Models.DTO;

namespace Logicathon.Profiles
{
    public class AutomapperProfile:Profile
    {
        public AutomapperProfile()
        {
            //ReverseMap() is used in case if we want to map DTO to the Domain Model
           
            CreateMap<Login, User>()
               .ReverseMap();
           
            

        }
    }
}
