using TussenTijdProject.Domain.Enums;

namespace TussenTijdProject.Client.Models
{
    public class CarsOverView
    {
        public int Id { get; set; }
        public int Category { get; set; }
        public string Model { get; set; }
        public CarType CarType { get; set; }
        public Brand Brand { get; set; }
        public FuelType FuelType { get; set; }
        public bool IsManual { get; set; }
    }
}
