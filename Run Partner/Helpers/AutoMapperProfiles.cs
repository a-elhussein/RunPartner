using AutoMapper;
using Run_Partner.DTOs;
using Run_Partner.Extensions;
using Run_Partner.Models;

namespace Run_Partner.Helpers
{
	public class AutoMapperProfiles: Profile
	{
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, MemberDto>()
                .ForMember(d => d.Age, o => o.MapFrom(s => s.DateOfBirth.CalculateAge()))
                .ForMember(d => d.PhotoUrl, o => 
                o.MapFrom(s => s.Photos.FirstOrDefault(x => x.IsMain)!.Url));
            CreateMap<Photo, PhotoDto >();
            CreateMap<MemberUpdateDto, AppUser >();
        }
    }
}
