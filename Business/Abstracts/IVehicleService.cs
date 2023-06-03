using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleAPI.Models;

namespace Business.Abstracts
{
    public interface IVehicleService
    {
        IEnumerable<Car> GetCarsByColor(string color);
        IEnumerable<Bus> GetBusesByColor(string color);
        IEnumerable<Boat> GetBoatsByColor(string color);
        IEnumerable<Bicycle> GetBicyclesByColor(string color);
        Car TurnOnOffCarHeadlights(int carId, bool on);
        void DeleteCar(int carId);
    }
}
