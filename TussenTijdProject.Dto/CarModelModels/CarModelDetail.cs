using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TussenTijdProject.Domain;
using TussenTijdProject.Domain.Enums;

namespace TussenTijdProject.Dto.CarModelModels;
public record CarModelDetail
{
    public int Id { get; set; }
    public int Category { get; set; }
    public string Pack { get; set; }
    public CarType CarType { get; set; }
    public Brand Brand { get; set; }
    public FuelType FuelType { get; set; }
    public string Model { get; set; }
    public int ExpectedDeliveryPeriodInMonths { get; set; }
    public string Remarks { get; set; }

    public int TechnicalSpecsId { get; set; }
    public virtual TechnicalSpecs TechnicalSpecs { get; set; }

    public int FiscalityId { get; set; }
    public virtual Fiscality Fiscality { get; set; }
}
