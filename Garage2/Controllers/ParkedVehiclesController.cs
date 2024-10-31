using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Garage2.Data;
using Garage2.Models;

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
        public async Task<IActionResult> Index()
        {

            return View(await _context.ParkedVehicle.ToListAsync());
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

        // GET: ParkedVehicles/Create
        public IActionResult Create()
        {
            // Get the enum values for VehicleType and create a SelectList
            ViewBag.VehicleTypes = Enum.GetValues(typeof(VehicleType))
                .Cast<VehicleType>()
                .Select(v => new SelectListItem
                {
                    Value = v.ToString(),
                    Text = v.ToString()
                });
            return View();
        }

        // POST: ParkedVehicles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,VehicleType,RegistrationNumber,Color,Make,Model,NumberOfWheels,ArrivalTime")] ParkedVehicle parkedVehicle)
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

            // Repopulate VehicleTypes for the dropdown in case of validation errors
            ViewBag.VehicleTypes = Enum.GetValues(typeof(VehicleType))
                .Cast<VehicleType>()
                .Select(v => new SelectListItem
                {
                    Value = v.ToString(),
                    Text = v.ToString()
                });

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

        // GET: ParkedVehicles/Delete/5
        public async Task<IActionResult> Delete(int? id)
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


		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
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

        public async Task<IActionResult> Search(string searchField, int type)
        {
            
            if (!string.IsNullOrEmpty(searchField))
            {
                if (type == 1)
                {
                    var results = _context.ParkedVehicle.Where(e => e.RegistrationNumber.Contains(searchField));

                    return View("Index", await results.ToListAsync());
                }
                else if (type == 2)
                {
                    var results = _context.ParkedVehicle.Where(e => e.VehicleType == searchField);

                    return View("Index", await results.ToListAsync());
                }
                else if (type == 3)
                {
                    var results = _context.ParkedVehicle.Where(e => e.Color == searchField);

                    return View("Index", await results.ToListAsync());
                }
                else if (type == 4)
                {
                    var results = _context.ParkedVehicle.Where(e => e.Make == searchField);

                    return View("Index", await results.ToListAsync());
                }
                else if (type == 5)
                {
                    var results = _context.ParkedVehicle.Where(e => e.Model == searchField);

                    return View("Index", await results.ToListAsync());
                }
                else
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }
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


	}
}
