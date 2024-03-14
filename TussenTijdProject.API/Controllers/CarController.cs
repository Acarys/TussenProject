using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TussenTijdProject.Dto.CarModelModels;
using TussenTijdProject.Service;
using TussentijdsProject.Domain;

namespace TussenTijdProject.API.Controllers;

[ApiController]
[Route("api/car")]
public class CarController : Controller
{
    private readonly ICarModelService _carModelService;
    private readonly IMapper _mapper;

    public CarController(ICarModelService carModelService, IMapper mapper)
    {
        _carModelService = carModelService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CarModelOverview>>> Get()
    {
        IEnumerable<CarModel> cars = await _carModelService.GetCarList();
        IEnumerable<CarModelOverview> result = _mapper.Map<IEnumerable<CarModel>, IEnumerable<CarModelOverview>>(cars);

        return Ok(result);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<CarModelDetail>> GetById(int id)
    {
        CarModel car = await _carModelService.GetCarById(id);
        if (car == null)
            return NotFound();

        CarModelDetail CarDetail = _mapper.Map<CarModelDetail>(car);
        return Ok(CarDetail);
    }
}
