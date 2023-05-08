using Microsoft.AspNetCore.Mvc;
using road_trip_api.Models;
using road_trip_api.Services;

namespace road_trip_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : Controller
    {
        private readonly ICarDetailServices _services;

        public CarController(ICarDetailServices services) 
        {
            _services = services;
        }
        [HttpGet("manufacturers")]
        public IResult Manufacturers()
        {
            return Results.Ok( _services.GetCarManufacturers());
        }
    }
}
