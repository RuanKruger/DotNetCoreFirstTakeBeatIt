using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetFirstTake.Models;
using DotNetFirstTake.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetFirstTake.Controllers
{
    public class HomeController : Controller
    {
		private readonly INecklaceRepository _necklaceRepository;

		public HomeController(INecklaceRepository necklaceRepository)
		{
			_necklaceRepository = necklaceRepository;
		}
        // GET: /<controller>/
        public IActionResult Index()
        {
			
			var necklaces = _necklaceRepository.GetAllNecklaces().OrderBy(x => x.Name);

			var homeViewModel = new HomeViewModel()
			{
				
				Title = "Welcome to BeadIT!",
				Necklaces = necklaces.ToList()
			};

            return View(homeViewModel);
        }

		public IActionResult Details(int id)
		{
			var necklace = _necklaceRepository.GetNecklaceById(id);
			if (necklace == null)
			{
				return NotFound();
			}
			return View(necklace);

		}


	   
	}
}
