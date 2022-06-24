using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;
using WebApplication1.ViewModels;

namespace WebApplication1.Areas.ProfiAdmin.Controllers
{
    [Area("ProfiAdmin")]
    public class TestimonialsController : Controller
    {
        private AppDbContext _context { get; set; }
        public TestimonialsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeViewModel test = new HomeViewModel
            {
                Testimonials = _context.Testimonials.ToList(),
            };
            return View(test);
        }
    }
}
