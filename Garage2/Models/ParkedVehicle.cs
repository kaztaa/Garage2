using System.ComponentModel.DataAnnotations;

namespace Garage2.Models
{
    public class ParkedVehicle
    {
        public int Id { get; set; }

        [Display(Name = "Vehicle type")]
        public required VehicleTypes VehicleType { get; set; }

        [Display(Name = "Registration number")]
        // Make sure regnr format is correct, first three should be letters and last three should be numbers
        [RegularExpression(@"^[A-Za-z]{3}[0-9]{3}$", ErrorMessage = "Registration number must have three letters followed by three digits (e.g., ABC123).")]
        public required string RegistrationNumber { get; set; }
        public required string Color { get; set; }

        [StringLength(12, MinimumLength = 2, ErrorMessage = "Make must be between 2 and 12 characters.")]
        public required string Make { get; set; }

        [StringLength(12, MinimumLength = 2, ErrorMessage = "Model must be between 2 and 12 characters.")]
        public required string Model { get; set; }

        [Display(Name = "Number of wheels")]
        [Range(1, 10, ErrorMessage = "Number of wheels must be at least 1 and at most 10.")]
        public int NumberOfWheels { get; set; }

        [Display(Name = "Arrival time")]
        public DateTime ArrivalTime { get; set; } = DateTime.Now;

        public DateTime? CheckoutTime {  get; set; }

        [Display(Name = "Parked duration")]
        public string ParkedDuration
        {
            get
            {
                var duration = DateTime.Now - ArrivalTime;
                return $"{duration.Hours} Hours, {duration.Minutes} minutes";
            }
        }

        [Display(Name = "Price per hour")]
        private const decimal PricePerHour = 10;

        [Display(Name = "Parking cost")]
        public decimal ParkingCost
		{
			get
			{
				if (ParkedDuration == null)
					return 999;
				var parkingDuration = DateTime.Now - ArrivalTime;
				return (decimal)parkingDuration.TotalHours * PricePerHour;
			}
		}

	}
}
