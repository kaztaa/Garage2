using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Garage2.Data;
using Garage2.Models;
using System.Globalization;

namespace Garage2.Controllers
{
    public class ParkedVehiclesController : Controller
    {
        private readonly Garage2Context _context;

        public ParkedVehiclesController(Garage2Context context)
        {
            _context = context;
        }

        // GET: ParkedVehicles
        public async Task<IActionResult> Index(string searchField, string sortBy, int type, string currentFilter, int currentType)
        {
            var vehicles = _context.ParkedVehicle.ToList();
            ViewData["TypeSortParam"] = sortBy == "type_desc" ? "type_asc" : "type_desc";
            ViewData["RegNrSortParam"] = sortBy == "regNr_desc" ? "regNr_asc" : "regNr_desc";
            ViewData["ArrivalTimeSortParam"] = sortBy == "at_desc" ? "at_asc" : "at_desc";
            ViewData["ParkedDurationSortParam"] = sortBy == "pd_desc" ? "pd_asc" : "pd_desc";


            if (string.IsNullOrEmpty(searchField))
            {
                searchField = currentFilter;
            }
            if (type == 0)
            {
                type = currentType;
            }

            ViewData["CurrentFilter"] = searchField;
            ViewData["CurrentType"] = type;

            if (!string.IsNullOrEmpty(searchField))
            {
                switch (type)
                {
                    case 1:
                        vehicles = vehicles.Where(e => e.RegistrationNumber.ToUpper().Contains(searchField.ToUpper())).ToList();
                        break;
                    case 2:
                        vehicles = vehicles.Where(e => e.VehicleType.ToString().ToUpper() == searchField.ToUpper()).ToList();
                        break;
                    case 3:
                        vehicles = vehicles.Where(e => e.Color.ToUpper() == searchField.ToUpper()).ToList();
                        break;
                    case 4:
                        vehicles = vehicles.Where(e => e.Make.ToUpper() == searchField.ToUpper()).ToList();
                        break;
                    case 5:
                        vehicles = vehicles.Where(e => e.Model.ToUpper() == searchField.ToUpper()).ToList();
                        break;
                }
            }

            switch (sortBy)
            {
                case "type_desc":
                    vehicles = vehicles.OrderByDescending(e => e.VehicleType).ToList();
                    break;
                case "type_asc":
                    vehicles = vehicles.OrderBy(e => e.VehicleType).ToList();
                    break;
                case "regNr_desc":
                    vehicles = vehicles.OrderByDescending(e => e.RegistrationNumber).ToList();
                    break;
                case "regNr_asc":
                    vehicles = vehicles.OrderBy(e => e.RegistrationNumber).ToList();
                    break;
                case "at_desc":
                    vehicles = vehicles.OrderByDescending(e => e.ArrivalTime).ToList();
                    break;
                case "at_asc":
                    vehicles = vehicles.OrderBy(e => e.ArrivalTime).ToList();
                    break;
                case "pt_desc":
                    vehicles = vehicles.OrderByDescending(e => e.ParkedDuration).ToList();
                    break;
                case "pt_asc":
                    vehicles = vehicles.OrderBy(e => e.ParkedDuration).ToList();
                    break;
            }

            return View(vehicles);
        }

        // GET: ParkedVehicles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parkedVehicle = await _context.ParkedVehicle
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parkedVehicle == null)
            {
                return NotFound();
            }

            return View(parkedVehicle);
        }

        // GET: ParkedVehicles/CheckIn
        public IActionResult CheckIn()
        {
            return View();
        }

        // POST: ParkedVehicles/CheckIn
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CheckIn([Bind("Id,VehicleType,RegistrationNumber,Color,Make,Model,NumberOfWheels,ArrivalTime")] ParkedVehicle parkedVehicle)
        {
            if (ModelState.IsValid)
            {
                // Check if a vehicle with the same RegistrationNumber already exists
                var existingVehicle = await _context.ParkedVehicle
                    .FirstOrDefaultAsync(v => v.RegistrationNumber == parkedVehicle.RegistrationNumber);

                if (existingVehicle != null)
                {
                    // Add an error to the ModelState if the registration number already exists
                    ModelState.AddModelError("RegistrationNumber", "This registration number already exists.");
                }

                if (ModelState.IsValid) // Re-check if the model state is valid after adding the error
                {
                    _context.Add(parkedVehicle);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }

            return View(parkedVehicle);
        }


        // GET: ParkedVehicles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parkedVehicle = await _context.ParkedVehicle.FindAsync(id);
            if (parkedVehicle == null)
            {
                return NotFound();
            }
            return View(parkedVehicle);
        }

        // POST: ParkedVehicles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,VehicleType,RegistrationNumber,Color,Make,Model,NumberOfWheels,ArrivalTime")] ParkedVehicle parkedVehicle)
        {
            if (id != parkedVehicle.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(parkedVehicle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParkedVehicleExists(parkedVehicle.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(parkedVehicle);
        }

        // GET: ParkedVehicles/CheckOut/5
        public async Task<IActionResult> CheckOut(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parkedVehicle = await _context.ParkedVehicle
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parkedVehicle == null)
            {
                return NotFound();
            }

            return View(parkedVehicle);
        }


		[HttpPost, ActionName("CheckOut")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> CheckOutConfirmed(int id)
		{
			var parkedVehicle = await _context.ParkedVehicle.FindAsync(id);
			if (parkedVehicle == null)
			{
				return NotFound();
			}

			var checkoutTime = DateTime.Now;
			var parkingDuration = checkoutTime - parkedVehicle.ArrivalTime;
			decimal pricePerHour = 10;
			decimal cost = (decimal)Math.Ceiling(parkingDuration.TotalHours) * pricePerHour;

			var receipt = new Receipt
			{
				RegistrationNumber = parkedVehicle.RegistrationNumber,
				ArrivalTime = parkedVehicle.ArrivalTime,
				CheckoutTime = checkoutTime,
				ParkingCost = cost
			};

			_context.ParkedVehicle.Remove(parkedVehicle);
			await _context.SaveChangesAsync();

			return View("Receipt", receipt);
		}


		private bool ParkedVehicleExists(int id)
        {
            return _context.ParkedVehicle.Any(e => e.Id == id);
        }

        public async Task<IActionResult> ParkingConfirmation(int id)
		{
			var vehicle = await _context.ParkedVehicle.FindAsync(id);
			if (vehicle == null)
			{
				return NotFound();
			}

			return View(vehicle); 
		}

		public async Task<IActionResult> Receipt(int id)
		{
			var vehicle = await _context.ParkedVehicle.FindAsync(id);
			if (vehicle == null || vehicle.CheckoutTime == null)
			{
                return NotFound();
                
			}

			var parkingDuration = vehicle.CheckoutTime.Value - vehicle.ArrivalTime;
			decimal pricePerHour = 10;
			decimal cost = (decimal)Math.Ceiling(parkingDuration.TotalHours) * pricePerHour;

			var receiptModel = new Receipt
			{
				RegistrationNumber = vehicle.RegistrationNumber,
				ArrivalTime = vehicle.ArrivalTime,
				CheckoutTime = vehicle.CheckoutTime.Value,
				ParkingCost = cost
			};

			return View("Receipt", receiptModel); 
		}

        public async Task<IActionResult> Stats(string sortBy)
        {

            decimal pricePerHour = 10; 

            var parkedVehicles = await _context.ParkedVehicle
                .Where(v => v.CheckoutTime == null) 
                .ToListAsync();

            var totalRevenue = parkedVehicles
                .Select(v => (decimal)(DateTime.Now - v.ArrivalTime).TotalHours * pricePerHour)
                .Sum(); 

            var stats = new Stats
            {


                TotalVehicles = await _context.ParkedVehicle.CountAsync(),
                Motorcycles = await _context.ParkedVehicle.CountAsync(v => v.VehicleType == VehicleTypes.Motorcycle),
                Cars = await _context.ParkedVehicle.CountAsync(v => v.VehicleType == VehicleTypes.Car),
                Trucks = await _context.ParkedVehicle.CountAsync(v => v.VehicleType == VehicleTypes.Truck),
                Buses = await _context.ParkedVehicle.CountAsync(v => v.VehicleType == VehicleTypes.Bus),
                Vans = await _context.ParkedVehicle.CountAsync(v => v.VehicleType == VehicleTypes.Van),
                Bicycles = await _context.ParkedVehicle.CountAsync(v => v.VehicleType == VehicleTypes.Bicycle),
                Wheels = await _context.ParkedVehicle.SumAsync(v => v.NumberOfWheels),
                Revenue = totalRevenue

            };

            return View("Stats", stats);
        }


    }
}
