using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using trankimxuanthuy_lab_456.Models;
using trankimxuanthuy_lab_456.ViewModels;

namespace trankimxuanthuy_lab_456.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext ;

      
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();

        }
        // GET: Courses
        public ActionResult create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList() 
            };
            return View(viewModel);
        }
    }
}