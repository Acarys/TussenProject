using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using TussenTijdProject.Database.Context;
using TussentijdsProject.Domain;

namespace TussenTijdProject.Service;
public class CarModelService : ICarModelService
{
    public readonly CarContext _ctx;

    public CarModelService(CarContext ctx)
    {
        _ctx = ctx;
    }

    public async Task<CarModel> CreateCar(CarModel car)
    {
        _ctx.CarModels.Add(car);
        await _ctx.SaveChangesAsync();
        return car;
    }

    public async Task<CarModel> GetCarById(int id)
    {
        CarModel car = await _ctx.CarModels
            .Include(car => car.Fiscality)
            .Include(car => car.TechnicalSpecs)
            .FirstOrDefaultAsync(car => car.Id == id);

        if (car == null)
            throw new Exception("Car not found");

        return car;
    }

    public async Task<IEnumerable<CarModel>> GetCarList()
    {
        return await _ctx.CarModels.ToListAsync();
    }
}
