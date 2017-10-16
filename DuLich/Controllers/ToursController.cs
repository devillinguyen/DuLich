using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using DuLich.Models;
using DuLich.ViewModels;

namespace DuLich.Controllers
{
    public class ToursController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public ToursController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Tours
        public ActionResult Index()
        {
            var tours = _dbContext.Tours.ToList();
            return View(tours);
        }
        [Authorize]
        // GET: Create a new Tour
        public ActionResult Create()
        {
            return View();
        }
        // POST: Create a new Tour
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TourViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Create");
            }
            var tour = new Tour
            {
                Name = viewModel.Name,
                ServicePackage = viewModel.ServicePackage,
                Image1 = viewModel.Image1,
                Image2 = viewModel.Image2,
                Image3 = viewModel.Image3,
                Description1 = viewModel.Description1,
                Description2 = viewModel.Description2
            };
            _dbContext.Tours.Add(tour);
            _dbContext.SaveChanges();
            return RedirectToAction("Index","Tours");
        }
    }
}