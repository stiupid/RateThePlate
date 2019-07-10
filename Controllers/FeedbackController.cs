using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RateThePlate.Models;
using System.Text.RegularExpressions;

namespace RateThePlate.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly lannisterContext _context;


        public FeedbackController(lannisterContext context)
        {
            _context = context;
        }

        // getting all the feedback
        public async Task<IActionResult> Index()
        {
            //including badges and carplates
            var feedbacks = _context.Feedback.Include(f => f.Badge).Include(f => f.CarPlate);
            //getting all the feedback//show only one instance of carplate number
            var badgeCountViewModels = feedbacks.GroupBy(b => b.CarPlate).Select(f => new BadgeCountViewModel
            {
                Feedback = f.First(),
                Count = 0
            });
            // vaidation for search string
            ViewData["Pattern"] = "(([a-zA-Z]{2}.?)|(B.?[0-9]?))[0-9]{2}.?[a-zA-Z]{3}";

            return View(await badgeCountViewModels.ToListAsync());
        }

        // searching for car plate number
        public ActionResult Search(string searchString)
        {
            //removing unnecessary chars 
            searchString = Regex.Replace(searchString.ToUpper(), "[^0-9A-Z]", "");
            var result = new List<BadgeCountViewModel>();

            if (!String.IsNullOrEmpty(searchString))
            {
                // getting the feedbacks that have the car plate number like the search string
                var feedbacks = _context.Feedback.Where(s => s.CarPlate.PlateNumber.Equals(searchString))
                    .Include(f => f.Badge).Include(f => f.CarPlate).ToList();
                //getting feedbacks that have the same badge and  the badgecount number
                result = feedbacks.GroupBy(x => x.Badge).Select(y => new BadgeCountViewModel
                {
                    Feedback = y.First(),
                    Count = y.Count()
                }).ToList();
                if (result.Count <= 0)
                {
                    ViewData["Error"] = $"The car plate number: \"{searchString}\" was not found in our database!";
                }
            }

            return View("Index", result);
        }

    }
}
