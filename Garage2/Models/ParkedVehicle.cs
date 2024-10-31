﻿using System.ComponentModel.DataAnnotations;

namespace Garage2.Models
{
    public class ParkedVehicle
    {
        public int Id { get; set; }
        public string VehicleType { get; set; }

        // Make sure regnr format is correct, first three should be letters and last three should be numbers
        [RegularExpression(@"^[A-Za-z]{3}[0-9]{3}$", ErrorMessage = "Registration number must have three letters followed by three digits (e.g., ABC123).")]
        public string RegistrationNumber { get; set; }
        public string Color { get; set; }

        [StringLength(12, MinimumLength = 2, ErrorMessage = "Make must be between 2 and 12 characters.")]
        public string Make { get; set; }

        [StringLength(12, MinimumLength = 2, ErrorMessage = "Model must be between 2 and 12 characters.")]
        public string Model { get; set; }

        [Range(1, 10, ErrorMessage = "Number of wheels must be at least 1 and at most 10.")]
        public int NumberOfWheels { get; set; }
        public DateTime ArrivalTime { get; set; } = DateTime.Now;

        public DateTime? CheckoutTime {  get; set; }

        public string ParkedDuration
        {
            get
            {
                var duration = DateTime.Now - ArrivalTime;
                return $"{duration.Hours} Hours, {duration.Minutes} minutes";
            }
        }

		private const decimal PricePerHour = 10;

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
