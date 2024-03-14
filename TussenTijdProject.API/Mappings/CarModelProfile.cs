using AutoMapper;
using TussenTijdProject.Dto.CarModelModels;
using TussentijdsProject.Domain;

namespace TussenTijdProject.API.Mappings;

public class CarModelProfile : Profile
{
    public CarModelProfile()
    {
        CreateMap<CarModel, CarItem>();
        CreateMap<CarModel, CarModelDetail>();
    }
}
