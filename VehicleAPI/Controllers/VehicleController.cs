using Microsoft.AspNetCore.Mvc;
using Models.Models;
using VehicleAPI.Models;
using VehicleAPI.Services;

namespace VehicleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly VehicleServices _vehicleServices;

        public VehicleController(VehicleServices vehicleService)
        {
            _vehicleServices = vehicleService;
        }

        [HttpGet("cars")]
        public IEnumerable<Vehicle> GetCars()
        {
            return _vehicleServices.GetCars().OfType<Car>();
        }

        [HttpGet("cars/{color}")]
        public IEnumerable<Vehicle> GetCarsByColor(string color)
        {
            return _vehicleServices.GetCarsByColor(color).OfType<Car>();
        }

        [HttpGet("buses/{color}")]
        public IEnumerable<Vehicle> GetBusesByColor(string color)
        {
            return _vehicleServices.GetBusesByColor(color).OfType<Bus>();
        }

        [HttpGet("boats/{color}")]
        public IEnumerable<Vehicle> GetBoatsByColor(string color)
        {
            return _vehicleServices.GetBoatsByColor(color).OfType<Boat>();
        }

        [HttpGet("bicycles/{color}")]
        public IEnumerable<Vehicle> GetBicyclesByColor(string color) {
            return _vehicleServices.GetBicyclesByColor(color).OfType<Bicycle>();
        }

        [HttpPost("cars/{id}/headlights")]
        public Car TurnOnOffCarHeadlights(int id, [FromBody] bool on)
        {
            return _vehicleServices.TurnOnOffCarHeadlights(id, on);
        }

        [HttpDelete("cars/{id}")]
        public string DeleteCar(int id)
        {
            _vehicleServices.DeleteCar(id);
            return "OK";
        }
    }
}
