using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationCertTanslation.Models;

namespace WebApplicationCertTanslation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Cert()
        {
            return View();
        }

        public IActionResult GetHtmlContent([FromBody] CertData certData)
        {
            return View("HtmlContent", certData); // Pass the data to the view
        }

        public IActionResult GetCivilReg ()
        {
            return View("CivilReg"); // Pass the data to the view
        }

        public IActionResult GetGeburts()
        {
            return View("Geburts"); // Pass the data to the view
        }

        public IActionResult GetEheBesch()
        {
            return View("Ehebescheinigung"); // Pass the data to the view
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
   
}
