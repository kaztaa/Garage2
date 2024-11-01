using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Garage2.Models;
using Humanizer.Localisation;

namespace Garage2.Data
{
    public class Garage2Context : DbContext
    {
        public Garage2Context (DbContextOptions<Garage2Context> options)
            : base(options)
        {
        }

        public DbSet<Garage2.Models.ParkedVehicle> ParkedVehicle { get; set; } = default!;



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ParkedVehicle>().HasData(
             new ParkedVehicle { Id = 1, VehicleType = VehicleTypes.Car, RegistrationNumber = "ABC123", Color = "Blue", Make = "Toyota", Model = "Corolla", NumberOfWheels = 4, ArrivalTime = DateTime.Now.AddHours(-2) },
             new ParkedVehicle { Id = 2, VehicleType = VehicleTypes.Car, RegistrationNumber = "ERT234", Color = "Green", Make = "Hundai", Model = "i3", NumberOfWheels = 4, ArrivalTime = DateTime.Now.AddHours(-2) },
             new ParkedVehicle { Id = 3, VehicleType = VehicleTypes.Car, RegistrationNumber = "ERR134", Color = "Balck", Make = "BMW", Model = "M3", NumberOfWheels = 4, ArrivalTime = DateTime.Now.AddHours(-2) },
             new ParkedVehicle { Id = 4, VehicleType = VehicleTypes.Motorcycle, RegistrationNumber = "HFF577", Color = "Red", Make = "Honda", Model = "Goldwing", NumberOfWheels = 2, ArrivalTime = DateTime.Now.AddHours(-2) },
             new ParkedVehicle { Id = 5, VehicleType = VehicleTypes.Motorcycle, RegistrationNumber = "OOP123", Color = "Green", Make = "Yamaha", Model = "R1", NumberOfWheels = 2, ArrivalTime = DateTime.Now.AddHours(-2) }

             );
        }

    }
}
