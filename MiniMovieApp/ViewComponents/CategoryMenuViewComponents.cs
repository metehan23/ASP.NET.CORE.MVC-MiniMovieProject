using Microsoft.AspNetCore.Mvc;
using MiniMovieApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniMovieApp.ViewComponents
{
    public class CategoryMenuViewComponents:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(CategorRepository.Categories);
        }
    }
}
