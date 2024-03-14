using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TussenTijdProject.Client.Helpers;
using TussenTijdProject.Client.Models;
using TussenTijdProject.Dto.CarModelModels;

namespace TussenTijdProject.Client.Controllers
{
    public class CarController : Controller
    {
        private readonly IMapper _mapper;

        public CarController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<IActionResult> OverView()
        {
            List<CarsOverView> model = new List<CarsOverView>();

            HttpClient client = new HttpClient();
            client = client.Configure();

            HttpResponseMessage res = await client.GetAsync("car");
            if (res.IsSuccessStatusCode)
            {
                IEnumerable<CarModelOverview>? cars = await res.Content.ReadFromJsonAsync<IEnumerable<CarModelOverview>>();
                IEnumerable<CarsOverView> result = _mapper.Map<IEnumerable<CarModelOverview>, IEnumerable<CarsOverView>>(cars);

                model.AddRange(result);
            }

            if (model == null)
            {
                TempData["error"] = "Something went wrong.";
            }
            return View(model);
        }

        public async Task<IActionResult> Details(int id)
        {
            CarModelViewModel model = new CarModelViewModel();

            HttpClient client = new HttpClient();
            client = client.Configure();

            HttpResponseMessage res = await client.GetAsync(client.BaseAddress + "car/" + id.ToString());
            if (res.IsSuccessStatusCode)
            {
                CarModelDetail car = await res.Content.ReadFromJsonAsync<CarModelDetail>();

                model = _mapper.Map<CarModelViewModel>(car);
            }

            return View(model);
        }
    }
}
