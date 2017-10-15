using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DuLich.Models;
using DuLich.ViewModels;

namespace DuLich.Controllers
{
    public class CarsController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        // Constructors
        public CarsController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Cars
        public ActionResult Index()
        {
            var cars = _dbContext.Cars
                .Include(m => m.Seat);
            return View(cars);
        }
        // GET: Create Cars
        public ActionResult Create()
        {
            var viewModel = new CarViewModel
            {
                Seats = _dbContext.Seats.ToList()
            };
            return View(viewModel);
        }
        // POST: Create Cars
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CarViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Seats = _dbContext.Seats.ToList();
                return View("Create", viewModel);
            }
            var car = new Car
            {
                Name = viewModel.Name,
                SeatId = viewModel.Seat,
                Color = viewModel.Color,
                Brand = viewModel.Brand,
                Price = viewModel.Price,
                Inventory = int.Parse(viewModel.Inventory),
                Image = viewModel.Image,
                Description = viewModel.Description,
            };
            _dbContext.Cars.Add(car);
            _dbContext.SaveChanges();
            return RedirectToAction("Index","Cars");
        }
    }
}