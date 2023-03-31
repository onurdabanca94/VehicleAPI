namespace VehicleAPI.Models
{
    public class Vehicle
    {
        public string? Id { get; set; }
        public string? Color { get; set; }
        public bool HeadlightsOn { get; set; }
    }
    public class Car : Vehicle
    {
        public int Wheels { get; set; }
    }

    public class Bus : Vehicle
    {

    }

    public class Boat : Vehicle
    {

    }
}