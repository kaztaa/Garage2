namespace Garage2.Models
{
    public class Receipt
    {
        public string RegistrationNumber { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }
        public TimeSpan ParkingDuration => DepartureTime - ArrivalTime;
        public decimal ParkingCost { get; set; }
    }
}
