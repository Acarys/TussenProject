﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TussenTijdProject.Database.Context;

#nullable disable

namespace TussenTijdProject.Database.Migrations
{
    [DbContext(typeof(CarContext))]
    partial class CarContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TussenTijdProject.Domain.Fiscality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("AmountDowngradeInclVAT")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("AmountUpgradeInclVAT")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("BenefitInKindPerMonth")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ListPriceExclVAT")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Fiscalities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AmountDowngradeInclVAT = 0m,
                            AmountUpgradeInclVAT = 0m,
                            BenefitInKindPerMonth = 500m,
                            ListPriceExclVAT = 80000m
                        },
                        new
                        {
                            Id = 2,
                            AmountDowngradeInclVAT = 0m,
                            AmountUpgradeInclVAT = 0m,
                            BenefitInKindPerMonth = 300m,
                            ListPriceExclVAT = 45000m
                        },
                        new
                        {
                            Id = 3,
                            AmountDowngradeInclVAT = 0m,
                            AmountUpgradeInclVAT = 0m,
                            BenefitInKindPerMonth = 400m,
                            ListPriceExclVAT = 60000m
                        });
                });

            modelBuilder.Entity("TussenTijdProject.Domain.TechnicalSpecs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BatteryCapacity")
                        .HasColumnType("int");

                    b.Property<int>("CO2")
                        .HasColumnType("int");

                    b.Property<double>("EVConsumption")
                        .HasColumnType("float");

                    b.Property<double>("FuelConsumption")
                        .HasColumnType("float");

                    b.Property<int>("Horsepower")
                        .HasColumnType("int");

                    b.Property<bool>("IsHeatPump")
                        .HasColumnType("bit");

                    b.Property<double>("MaxACCharging")
                        .HasColumnType("float");

                    b.Property<double>("MaxDCCharging")
                        .HasColumnType("float");

                    b.Property<int>("MaxTowingCapacity")
                        .HasColumnType("int");

                    b.Property<int>("RealRange")
                        .HasColumnType("int");

                    b.Property<int>("WLTPRange")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TechnicalSpecs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BatteryCapacity = 100,
                            CO2 = 0,
                            EVConsumption = 0.0,
                            FuelConsumption = 0.0,
                            Horsepower = 400,
                            IsHeatPump = true,
                            MaxACCharging = 11.0,
                            MaxDCCharging = 150.0,
                            MaxTowingCapacity = 2000,
                            RealRange = 450,
                            WLTPRange = 500
                        },
                        new
                        {
                            Id = 2,
                            BatteryCapacity = 0,
                            CO2 = 120,
                            EVConsumption = 0.0,
                            FuelConsumption = 6.5,
                            Horsepower = 150,
                            IsHeatPump = false,
                            MaxACCharging = 7.4000000000000004,
                            MaxDCCharging = 0.0,
                            MaxTowingCapacity = 1800,
                            RealRange = 350,
                            WLTPRange = 400
                        },
                        new
                        {
                            Id = 3,
                            BatteryCapacity = 0,
                            CO2 = 100,
                            EVConsumption = 0.0,
                            FuelConsumption = 5.5,
                            Horsepower = 200,
                            IsHeatPump = false,
                            MaxACCharging = 7.2000000000000002,
                            MaxDCCharging = 0.0,
                            MaxTowingCapacity = 1500,
                            RealRange = 500,
                            WLTPRange = 550
                        });
                });

            modelBuilder.Entity("TussentijdsProject.Domain.CarModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Brand")
                        .HasColumnType("int");

                    b.Property<int>("CarType")
                        .HasColumnType("int");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<int>("ExpectedDeliveryPeriodInMonths")
                        .HasColumnType("int");

                    b.Property<int>("FiscalityId")
                        .HasColumnType("int");

                    b.Property<int>("FuelType")
                        .HasColumnType("int");

                    b.Property<bool>("IsManual")
                        .HasColumnType("bit");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pack")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TechnicalSpecsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FiscalityId")
                        .IsUnique();

                    b.HasIndex("TechnicalSpecsId")
                        .IsUnique();

                    b.ToTable("CarModels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = 5,
                            CarType = 3,
                            Category = 1,
                            ExpectedDeliveryPeriodInMonths = 3,
                            FiscalityId = 1,
                            FuelType = 1,
                            IsManual = false,
                            Model = "Model X",
                            Pack = "Standard",
                            Remarks = "Luxury SUV",
                            TechnicalSpecsId = 1
                        },
                        new
                        {
                            Id = 2,
                            Brand = 1,
                            CarType = 3,
                            Category = 2,
                            ExpectedDeliveryPeriodInMonths = 2,
                            FiscalityId = 2,
                            FuelType = 0,
                            IsManual = false,
                            Model = "Tiguan",
                            Pack = "Comfort",
                            Remarks = "Family SUV",
                            TechnicalSpecsId = 2
                        },
                        new
                        {
                            Id = 3,
                            Brand = 0,
                            CarType = 1,
                            Category = 3,
                            ExpectedDeliveryPeriodInMonths = 2,
                            FiscalityId = 3,
                            FuelType = 0,
                            IsManual = true,
                            Model = "A4",
                            Pack = "Luxury",
                            Remarks = "Executive Sedan",
                            TechnicalSpecsId = 3
                        });
                });

            modelBuilder.Entity("TussentijdsProject.Domain.CarModel", b =>
                {
                    b.HasOne("TussenTijdProject.Domain.Fiscality", "Fiscality")
                        .WithOne()
                        .HasForeignKey("TussentijdsProject.Domain.CarModel", "FiscalityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TussenTijdProject.Domain.TechnicalSpecs", "TechnicalSpecs")
                        .WithOne()
                        .HasForeignKey("TussentijdsProject.Domain.CarModel", "TechnicalSpecsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fiscality");

                    b.Navigation("TechnicalSpecs");
                });
#pragma warning restore 612, 618
        }
    }
}
