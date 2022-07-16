using CRUD___MVC___NET_5.context;
using CRUD___MVC___NET_5.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD___MVC___NET_5.Controllers
{
    public class VehiclesController : Controller
    {
        private readonly DataContext _DataContext;
        public VehiclesController(DataContext context)
        {
            _DataContext = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Vehicle> Vehicle = _DataContext.Vehicle;
            return View(Vehicle);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Vehicle Vehicle)
        {
            if (ModelState.IsValid)
            {
                _DataContext.Vehicle.Add(Vehicle);
                _DataContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int? Id)
        {
            if(Id == null || Id == 0)
            {
                return NotFound();
            }

            var Vehicle = _DataContext.Vehicle.Find(Id);

            if (Vehicle == null)
            {
                return NotFound();
            }
            
            return View(Vehicle);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Vehicle Vehicle)
        {
            if (ModelState.IsValid)
            {
                _DataContext.Vehicle.Update(Vehicle);
                _DataContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            var Vehicle = _DataContext.Vehicle.Find(Id);

            if (Vehicle == null)
            {
                return NotFound();
            }

            return View(Vehicle);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteV(int? Id)
        {
            var vehicle =  _DataContext.Vehicle.Find(Id);

            if (vehicle == null)
            {
                return NotFound();
            }

            _DataContext.Vehicle.Remove(vehicle);
            _DataContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
