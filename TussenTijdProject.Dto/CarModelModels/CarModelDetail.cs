using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TussenTijdProject.Domain;
using TussenTijdProject.Domain.Enums;
using TussenTijdProject.Dto.FiscalityModels;
using TussenTijdProject.Dto.TechnicalSpecsModels;

namespace TussenTijdProject.Dto.CarModelModels;
public record CarModelDetail
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
    public TechnicalSpecsItem TechnicalSpecs { get; set; }
    public FiscalityItem Fiscality { get; set; }
}
