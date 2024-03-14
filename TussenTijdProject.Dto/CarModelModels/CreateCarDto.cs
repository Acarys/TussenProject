using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TussenTijdProject.Domain.Enums;

namespace TussenTijdProject.Dto.CarModelModels;
public record CreateCarDto
{
    public int Category { get; set; }
    public string Pack { get; set; }
    public CarType CarType { get; set; }
    public Brand Brand { get; set; }
    public FuelType FuelType { get; set; }
    public string Model { get; set; }
    public bool IsManual { get; set; }
    public int ExpectedDeliveryPeriodInMonths { get; set; }
    public string Remarks { get; set; }
}
