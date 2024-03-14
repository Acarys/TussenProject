using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using TussenTijdProject.Domain;
using TussenTijdProject.Domain.Enums;
using TussentijdsProject.Domain;

namespace TussenTijdProject.Database.Context;
public class CarContext : DbContext
{
    public DbSet<CarModel> CarModels { get; set; }
    public DbSet<Fiscality> Fiscalities { get; set; }
    public DbSet<TechnicalSpecs> TechnicalSpecs { get; set; }

    public CarContext(DbContextOptions<CarContext> options): base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CarModel>()
        .HasOne(c => c.Fiscality)
        .WithOne()
        .HasForeignKey<CarModel>(c => c.FiscalityId);

        modelBuilder.Entity<CarModel>()
            .HasOne(c => c.TechnicalSpecs)
            .WithOne()
            .HasForeignKey<CarModel>(t => t.TechnicalSpecsId);

        // Seed data for Fiscality
        modelBuilder.Entity<Fiscality>().HasData(
            new Fiscality
            {
                Id = 1,
                ListPriceExclVAT = 80000,
                BenefitInKindPerMonth = 500,
                AmountUpgradeInclVAT = 0,
                AmountDowngradeInclVAT = 0
            },
            new Fiscality
            {
                Id = 2,
                ListPriceExclVAT = 45000,
                BenefitInKindPerMonth = 300,
                AmountUpgradeInclVAT = 0,
                AmountDowngradeInclVAT = 0
            },
            new Fiscality
            {
                Id = 3,
                ListPriceExclVAT = 60000,
                BenefitInKindPerMonth = 400,
                AmountUpgradeInclVAT = 0,
                AmountDowngradeInclVAT = 0
            }
        );

        // Seed data for TechnicalSpecs
        modelBuilder.Entity<TechnicalSpecs>().HasData(
            new TechnicalSpecs
            {
                Id = 1,
                FuelConsumption = 0,
                EVConsumption = 0,
                BatteryCapacity = 100,
                Horsepower = 400,
                MaxTowingCapacity = 2000,
                MaxDCCharging = 150,
                MaxACCharging = 11,
                IsHeatPump = true,
                WLTPRange = 500,
                RealRange = 450,
                CO2 = 0
            },
            new TechnicalSpecs
            {
                Id = 2,
                FuelConsumption = 6.5,
                EVConsumption = 0,
                BatteryCapacity = 0,
                Horsepower = 150,
                MaxTowingCapacity = 1800,
                MaxDCCharging = 0,
                MaxACCharging = 7.4,
                IsHeatPump = false,
                WLTPRange = 400,
                RealRange = 350,
                CO2 = 120
            },
            new TechnicalSpecs
            {
                Id = 3,
                FuelConsumption = 5.5,
                EVConsumption = 0,
                BatteryCapacity = 0,
                Horsepower = 200,
                MaxTowingCapacity = 1500,
                MaxDCCharging = 0,
                MaxACCharging = 7.2,
                IsHeatPump = false,
                WLTPRange = 550,
                RealRange = 500,
                CO2 = 100
            }
        );

        // Seed data for CarModel
        modelBuilder.Entity<CarModel>().HasData(
            new CarModel
            {
                Id = 1,
                Category = 1,
                Pack = "Standard",
                CarType = CarType.SUV,
                Brand = Brand.Tesla,
                FuelType = FuelType.Electric,
                IsManual = false,
                Model = "Model X",
                ExpectedDeliveryPeriodInMonths = 3,
                Remarks = "Luxury SUV",
                FiscalityId = 1,
                TechnicalSpecsId = 1
            },
            new CarModel
            {
                Id = 2,
                Category = 2,
                Pack = "Comfort",
                CarType = CarType.SUV,
                Brand = Brand.VW,
                FuelType = FuelType.Petrol,
                Model = "Tiguan",
                IsManual = false,
                ExpectedDeliveryPeriodInMonths = 2,
                Remarks = "Family SUV",
                FiscalityId = 2,
                TechnicalSpecsId = 2
            },
            new CarModel
            {
                Id = 3,
                Category = 3,
                Pack = "Luxury",
                CarType = CarType.Berline,
                Brand = Brand.Audi,
                FuelType = FuelType.Petrol,
                Model = "A4",
                IsManual = true,
                ExpectedDeliveryPeriodInMonths = 2,
                Remarks = "Executive Sedan",
                FiscalityId = 3,
                TechnicalSpecsId = 3
            }
        );

        base.OnModelCreating(modelBuilder);
    }
}
