using Business.Abstracts;
using System.Collections.Generic;
using System.Linq;
using VehicleAPI.Models;


namespace VehicleAPI.Services
{
    public class VehicleServices : IVehicleService
    {
        private readonly List<Car> _cars;
        private readonly List<Bus> _buses;
        private readonly List<Boat> _boats;

        public VehicleServices()
        {
            _cars = new List<Car>()
            {
                new Car { Id = "1", Color = "red", Wheels = 4, HeadlightsOn = false},
                new Car { Id = "2", Color = "blue", Wheels = 4, HeadlightsOn = true},
                new Car { Id = "3", Color = "black", Wheels = 4, HeadlightsOn = false},
                new Car { Id = "4", Color = "white", Wheels = 4, HeadlightsOn = true},
            };

            _buses = new List<Bus>()
            {
                new Bus() { Id = "1", Color = "red" },
                new Bus() { Id = "2", Color = "blue" },
                new Bus() { Id = "3", Color = "black" },
                new Bus() { Id = "4", Color = "white" },
            };

            _boats = new List<Boat>()
            {
                new Boat() { Id = "1", Color = "red" },
                new Boat() { Id = "2", Color = "blue" },
                new Boat() { Id = "3", Color = "black" },
                new Boat() { Id = "4", Color = "white" },
            };
        }

        public IEnumerable<Car> GetCarsByColor(string color)
        {
            return _cars.Where(c => c.Color.Equals(color, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<Bus> GetBusesByColor(string color)
        {
            return _buses.Where(b => b.Color.Equals(color, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<Boat> GetBoatsByColor(string color)
        {
            return _boats.Where(b => b.Color.Equals(color, StringComparison.OrdinalIgnoreCase));
        }

        public void TurnOnOffCarHeadlights(int carId, bool on)
        {
            var car = _cars.FirstOrDefault(c => c.Id == carId.ToString());
            if (car != null) 
            {
                car.HeadlightsOn = on;    
            }
        }

        public void DeleteCar(int carId)
        {
            var car = _cars.FirstOrDefault(c => c.Id == carId.ToString());
            if (car != null)
            {
                _cars.Remove(car);
            }
        }
    }
}
