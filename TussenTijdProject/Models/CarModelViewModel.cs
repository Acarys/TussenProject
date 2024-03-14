using TussenTijdProject.Domain;
using TussenTijdProject.Domain.Enums;
using TussenTijdProject.Dto.FiscalityModels;
using TussenTijdProject.Dto.TechnicalSpecsModels;

namespace TussenTijdProject.Client.Models
{
    public class CarModelViewModel
    {
        public int Category { get; set; }
        public string Pack { get; set; }
        public Domain.Enums.CarType CarType { get; set; }
        public Brand Brand { get; set; }
        public FuelType FuelType { get; set; }
        public string Model { get; set; }
        public bool IsManual { get; set; }
        public int ExpectedDeliveryPeriodInMonths { get; set; }
        public string Remarks { get; set; }
        public TechnicalSpecsItemDto TechnicalSpecs { get; set; }
        public FiscalityItemDto Fiscality { get; set; }
    }
}
