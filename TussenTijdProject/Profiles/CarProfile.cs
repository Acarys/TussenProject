using TussenTijdProject.Client.Models;
using TussentijdsProject.Domain;
using AutoMapper;
using TussenTijdProject.Dto.CarModelModels;

namespace TussenTijdProject.Client.Profiles
{
    public class CarProfile: Profile
    {
        public CarProfile()
        {
            CreateMap<CarItem, CarsOverView>();
            CreateMap<CarModelDetail, TussentijdsProject.Domain.CarModel>();
        }
    }
}
