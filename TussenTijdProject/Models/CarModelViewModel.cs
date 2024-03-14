using TussenTijdProject.Domain;
using TussenTijdProject.Domain.Enums;

namespace TussenTijdProject.Client.Models
{
    public class CarModelViewModel
    {
        public int Id { get; set; }
        public int Category { get; set; }
        public string Pack { get; set; }
        public Domain.Enums.CarType CarType { get; set; }
        public Brand Brand { get; set; }
        public FuelType FuelType { get; set; }
        public string Model { get; set; }
        public int ExpectedDeliveryPeriodInMonths { get; set; }
        public string Remarks { get; set; }
        public virtual TechnicalSpecs TechnicalSpecs { get; set; }
        public virtual Fiscality Fiscality { get; set; }
    }
}
