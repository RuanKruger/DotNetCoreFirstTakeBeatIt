using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetFirstTake.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetFirstTake.Controllers
{
    public class FeedbackController : Controller
    {
	    private readonly IFeedbackRepository _feedbackRepository;

	    public FeedbackController(IFeedbackRepository feedback)
	    {
		    _feedbackRepository = feedback;
	    }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

		[HttpPost]
	    public IActionResult Index(Feedback feedback)
	    {
			_feedbackRepository.AddFeedback(feedback);
		    return RedirectToAction("FeedbackComplete");
	    }

	    public IActionResult FeedbackComplete()
	    {
		    return View();
	    }
    }
}
