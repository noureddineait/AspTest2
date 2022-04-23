using Microsoft.AspNetCore.Mvc;

namespace WebApplicationTest.Controllers
{
    public class HomeController : Controller
    {
        Models.ApplicationDbContext context = new Models.ApplicationDbContext();
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Models.Conversion conversion)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Test",conversion);
            }
            return View(conversion);                 
        }
        public IActionResult Test(Models.Conversion conversion)
        {
            if (conversion.FinalMetric == "Fahrenheit")
            {
                conversion.FinalValue = (conversion.InitialValue * (9f / 5f)) + 32f;
                conversion.InitialMetric = "Celsius";
            }
            else
            {
                conversion.FinalValue = (conversion.InitialValue - 32f) * (5f / 9f);
                conversion.InitialMetric = "Fahrenheit";
            }
            
            context.conversions.Add(conversion);
            context.SaveChanges();
            return View(conversion);
        }
        public IActionResult History()
        {
            ViewBag.Test = "HELLO";
            List<Models.Conversion> conversions = context.conversions.ToList();

            return View(conversions);
        }
    }

}
