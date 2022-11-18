using AutoMapper;

namespace Repo1.API.Profiles
{
    public class RegionsProfilescs:Profile
    {
        public RegionsProfilescs()
        {
            CreateMap<Models.Domain.Region, Models.DTO.Region>()
                .ReverseMap();
        }
    }
}
