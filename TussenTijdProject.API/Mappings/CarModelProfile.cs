using AutoMapper;
using TussenTijdProject.Domain;
using TussenTijdProject.Dto.CarModelModels;
using TussenTijdProject.Dto.FiscalityModels;
using TussenTijdProject.Dto.TechnicalSpecsModels;
using TussentijdsProject.Domain;

namespace TussenTijdProject.API.Mappings;

public class CarModelProfile : Profile
{
    public CarModelProfile()
    {
        CreateMap<CarModel, CarItemDto>();
        CreateMap<CarModel, CarModelDetailDto>();
        CreateMap<CarModel, CreateCarDto>();
        CreateMap<TechnicalSpecs, TechnicalSpecsItemDto>();
        CreateMap<Fiscality, FiscalityItemDto>();
    }
}
