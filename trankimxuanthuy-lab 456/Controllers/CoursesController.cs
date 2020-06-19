using Microsoft.AspNet.Identity;
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
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult create(CourseViewModel viewModel)
        {
            if(!ModelState.IsValid)
            {
                viewModel.Categories = _dbContext.Categories.ToList();
                return View("Create", viewModel);
            }
            var course = new Course
            {
                LeturerId = User.Identity.GetUserId(),
                Datetime = viewModel.GetDataTime(),
                CategoryId = viewModel.Category,
                Place = viewModel.Place
                
            };
            _dbContext.Courses.Add(course);
            _dbContext.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

    }

}