using Microsoft.AspNetCore.Mvc;
using Pustok_Project.DAL;
using Pustok_Project.Models;
using Pustok_Project.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Pustok_Project.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            List<Feature> features = _context.Features.ToList();


            HomeViewModel homeViewModel = new HomeViewModel
            {
                Sliders = sliders,
                Features = features
            };

            return View(homeViewModel);
        }
    }
}
