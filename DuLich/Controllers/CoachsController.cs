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
    public class CoachsController : Controller
    {
        // Fields
        private readonly ApplicationDbContext _dbContext;
        // Constructors
        public CoachsController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Coach
        public ActionResult Index()
        {
            var coachs = _dbContext.Coaches
                .Include(m => m.Seat);
            return View(coachs);
        }
        // GET: Create a new Coach
        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new CoachViewModel
            {
                Seats = _dbContext.Seats.ToList()
            };
            return View(viewModel);
        }
        // POST: Create a new Coach
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CoachViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Seats = _dbContext.Seats.ToList();
                return View("Create", viewModel);
            }
            var coach = new Coach
            {
                Name = viewModel.Name,
                SeatId = viewModel.Seat
            };
            _dbContext.Coaches.Add(coach);
            _dbContext.SaveChanges();
            return RedirectToAction("Index", "Coachs");
        }
    }
}