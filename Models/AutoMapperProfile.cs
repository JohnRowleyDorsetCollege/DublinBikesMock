using AutoMapper;

namespace DublinBikesMock.Models
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() { 
        CreateMap<BikeStation, BikeStationDto>();
        }
    }
}
