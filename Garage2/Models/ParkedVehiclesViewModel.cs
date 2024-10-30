namespace Garage2.Models
{
    public class ParkedVehiclesViewModel
    {
        public int Id { get; set; }
        public string VehicleType { get; set; }
        public string RegistrationNumber { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime ParkedTime { get; set; }
    }
}
