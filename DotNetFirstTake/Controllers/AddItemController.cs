using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetFirstTake.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetFirstTake.Controllers
{
    public class AddItemController : Controller
	{
	    private readonly INecklaceRepository _necklaceRepository;

		public AddItemController(INecklaceRepository submitItem)
		{
			_necklaceRepository = submitItem;
		}
		
	    // GET: /<controller>/
	    public IActionResult Index()
	    {
		    return View();
	    }

		[HttpPost]
	    public IActionResult Index(Necklace necklace)
	    {
		    if (ModelState.IsValid)
		    {
			    _necklaceRepository.AddNecklaceInDb(necklace);
			    return RedirectToAction("ItemAddedSuccess");
		    }

		    return View(necklace);
	    }

	    public IActionResult ItemAddedSuccess()
	    {
		    return View();
	    }

	}
}
