using Microsoft.AspNetCore.Mvc;
using TussenTijdProject.Client.Models;

namespace TussenTijdProject.Client.Controllers
{
    public class CarController : Controller
    {
        public IActionResult OverView()
        {
            List<CarModel> carModels = new List<CarModel>
        {
            new CarModel
            {
                Category = 1,
                Type = TussenTijdProject.Domain.CarType.Electric,
                Sort = TussenTijdProject.Domain.Sort.Break,
                Brand = "Brand1",
                Model = "Model1",
                Pack = "Pack1",
                IsManual = true,
                IsHeatPump = false,
                WLTPRange = 100,
                RealRange = 80,
                ListPriceExclVAT = 20000,
                CO2 = 120,
                BenefitInKindPerMonth = 150,
                AmountUpgradeInclVAT = 500,
                AmountDowngradeInclVAT = 300,
                FuelConsumption = 7.5,
                EVConsumption = 2.5,
                BatteryCapacity = 75,
                Horsepower = 150,
                MaxTowingCapacity = 2000,
                MaxDCCharging = 50,
                MaxACCharging = 22,
                ExpectedDeliveryPeriodInMonths = 3,
                Remarks = "Remark1"
            },
            new CarModel
            {
                Category = 1,
                Type = TussenTijdProject.Domain.CarType.Electric,
                Sort = TussenTijdProject.Domain.Sort.Break,
                Brand = "Brand1",
                Model = "Model1",
                Pack = "Pack1",
                IsManual = true,
                IsHeatPump = false,
                WLTPRange = 100,
                RealRange = 80,
                ListPriceExclVAT = 20000,
                CO2 = 120,
                BenefitInKindPerMonth = 150,
                AmountUpgradeInclVAT = 500,
                AmountDowngradeInclVAT = 300,
                FuelConsumption = 7.5,
                EVConsumption = 2.5,
                BatteryCapacity = 75,
                Horsepower = 150,
                MaxTowingCapacity = 2000,
                MaxDCCharging = 50,
                MaxACCharging = 22,
                ExpectedDeliveryPeriodInMonths = 3,
                Remarks = "Remark1"
            },
             new CarModel
            {
                Category = 1,
                Type = TussenTijdProject.Domain.CarType.Electric,
                Sort = TussenTijdProject.Domain.Sort.Break,
                Brand = "Brand1",
                Model = "Model1",
                Pack = "Pack1",
                IsManual = true,
                IsHeatPump = false,
                WLTPRange = 100,
                RealRange = 80,
                ListPriceExclVAT = 20000,
                CO2 = 120,
                BenefitInKindPerMonth = 150,
                AmountUpgradeInclVAT = 500,
                AmountDowngradeInclVAT = 300,
                FuelConsumption = 7.5,
                EVConsumption = 2.5,
                BatteryCapacity = 75,
                Horsepower = 150,
                MaxTowingCapacity = 2000,
                MaxDCCharging = 50,
                MaxACCharging = 22,
                ExpectedDeliveryPeriodInMonths = 3,
                Remarks = "Remark1"
            },
        };
            return View(carModels);
        }

        public IActionResult Details()
        {
            CarModel car = new CarModel
            {
                Category = 1,
                Type = TussenTijdProject.Domain.CarType.Electric,
                Sort = TussenTijdProject.Domain.Sort.Break,
                Brand = "Brand1",
                Model = "Model1",
                Pack = "Pack1",
                IsManual = true,
                IsHeatPump = false,
                WLTPRange = 100,
                RealRange = 80,
                ListPriceExclVAT = 20000,
                CO2 = 120,
                BenefitInKindPerMonth = 150,
                AmountUpgradeInclVAT = 500,
                AmountDowngradeInclVAT = 300,
                FuelConsumption = 7.5,
                EVConsumption = 2.5,
                BatteryCapacity = 75,
                Horsepower = 150,
                MaxTowingCapacity = 2000,
                MaxDCCharging = 50,
                MaxACCharging = 22,
                ExpectedDeliveryPeriodInMonths = 3,
                Remarks = "Remark1"
            };
            return View(car);
        }
    }
}
