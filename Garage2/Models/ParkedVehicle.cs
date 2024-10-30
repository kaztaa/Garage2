namespace Garage2.Models
{
    public class ParkedVehicle
    {
        public int Id { get; set; }
        public string VehicleType { get; set; }
        public string RegistrationNumber { get; set; }
        public string Color { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int NumberOfWheels { get; set; }

        // DateTime.Now = som timestamp, vid parkering ska ArrivalTime använda nuvarande tid
        public DateTime ArrivalTime { get; set; } = DateTime.Now;
        public DateTime? CheckoutTime {  get; set; }

    }
}
