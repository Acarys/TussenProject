using TussenTijdProject.Domain;

namespace TussentijdsProject.Domain;
public enum Sort { SUV, Break, Berline, Hatchback, MPV }


public class CarModel
{
    public int Id { get; set; }
    public int Category { get; set; }
    public string Model { get; set; }
    public string Pack { get; set; }
    public bool IsManual { get; set; }
    public bool IsHeatPump { get; set; }
    public int WLTPRange { get; set; }
    public int RealRange { get; set; }
    public decimal ListPriceExclVAT { get; set; }
    public int CO2 { get; set; }
    public decimal BenefitInKindPerMonth { get; set; }
    public decimal AmountUpgradeInclVAT { get; set; }
    public decimal AmountDowngradeInclVAT { get; set; }
    public double FuelConsumption { get; set; }
    public double EVConsumption { get; set; }
    public int BatteryCapacity { get; set; }
    public int Horsepower { get; set; }
    public int MaxTowingCapacity { get; set; }
    public double MaxDCCharging { get; set; }
    public double MaxACCharging { get; set; }
    public int ExpectedDeliveryPeriodInMonths { get; set; }
    public string Remarks { get; set; }

    public int BrandId { get; set; }
    public virtual Brand Brand { get; set; }

    public int TypeId { get; set; }
    public virtual Type Type { get; set; }

    public int SortId { get; set; }
    public Sort Sort { get; set; }
}
