using TussenTijdProject.Client.Models;
using TussentijdsProject.Domain;
using AutoMapper;

namespace TussenTijdProject.Client.Profiles
{
    public class CarProfile: Profile
    {
        public CarProfile()
        {
           CreateMap<CarModel, Car>();
               
        }
    }
}
