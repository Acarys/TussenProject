using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TussenTijdProject.Dto.TechnicalSpecsModels;
public record TechnicalSpecsItemDto
{
    public double FuelConsumption { get; set; }
    public double EVConsumption { get; set; }
    public int BatteryCapacity { get; set; }
    public int Horsepower { get; set; }
    public int MaxTowingCapacity { get; set; }
    public double MaxDCCharging { get; set; }
    public double MaxACCharging { get; set; }
    public bool IsHeatPump { get; set; }
    public int WLTPRange { get; set; }
    public int RealRange { get; set; }
    public int CO2 { get; set; }
}
