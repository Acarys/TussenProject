﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TussenTijdProject.Domain.Enums;

namespace TussenTijdProject.Dto.CarModelModels;
public record CarItemDto
{
    public int Id { get; set; }
    public int Category { get; set; }
    public string Model { get; set; }
    public CarType CarType { get; set; }
    public Brand Brand { get; set; }
    public FuelType FuelType { get; set; }
    public bool IsManual { get; set; }
    public int ExpectedDeliveryPeriodInMonths { get; set; }
}
