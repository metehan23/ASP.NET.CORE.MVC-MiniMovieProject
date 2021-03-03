using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MiniMovieApp.Data;
using MiniMovieApp.Models;

namespace MiniMovieApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int? id)
        {

            MovieCategoryModel model = new MovieCategoryModel();
            model.Categories = CategorRepository.Categories;
            model.Movies = MovieRepository.Movies;
            if (id!=null)
            {
                model.Movies = MovieRepository.Movies;
            }
            return View(model);
        }
        public IActionResult Details(int id)
        {
            MovieCategoryModel model = new MovieCategoryModel();
            model.Categories = CategorRepository.Categories;
            model.Movie = MovieRepository.GetById(id);
            return View(model);
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
