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
    public async Task<ActionResult<IEnumerable<CarItemDto>>> Get()
    {
        IEnumerable<CarModel> cars = await _carModelService.GetCarList();
        IEnumerable<CarItemDto> result = _mapper.Map<IEnumerable<CarModel>, IEnumerable<CarItemDto>>(cars);

        return Ok(result);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<CarModelDetailDto>> GetById(int id)
    {
        CarModel car = await _carModelService.GetCarById(id);
        if (car == null)
            return NotFound();

        CarModelDetailDto CarDetail = _mapper.Map<CarModelDetailDto>(car);
        return Ok(CarDetail);
    }

    [HttpPost]
    public async Task<ActionResult> Create([FromBody] CreateCarDto createCar)
    {
        CarModel car = _mapper.Map<CarModel>(createCar);
        await _carModelService.CreateCar(car);
        CarModelDetailDto carDetail = _mapper.Map<CarModelDetailDto>(car);
        return CreatedAtAction(nameof(Get), new { Id = car.Id }, carDetail);
    }
}
