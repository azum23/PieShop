using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PieShop.Models;
using PieShop.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public ViewResult List()
        {
            PiesListViewModel piesListViewModel = new PiesListViewModel();
            piesListViewModel.CurrentCategory = "Cheese cakes";
            piesListViewModel.Pies = _pieRepository.Pies;
                //.Where(p => p.Category.CategoryName.Equals(piesListViewModel.CurrentCategory.ToString()))
                //.Select(p => p);
            ViewBag.Title = "Pie Shop";

            return View(piesListViewModel);
        }
    }
}
