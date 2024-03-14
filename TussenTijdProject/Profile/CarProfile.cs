using TussenTijdProject.Client.Models;
using TussentijdsProject.Domain;
using AutoMapper;

namespace TussenTijdProject.Client.Profile
{
    public class CarProfile
    {
        public CarProfile()
        {
           CreateMap<CarModel, Car>();
               
        }
    }
}
