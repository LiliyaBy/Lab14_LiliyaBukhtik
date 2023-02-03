using Lab14_LiliyaBukhtik.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;


namespace Lab14_LiliyaBukhtik.Controllers
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

        [HttpPost]
        public IActionResult Registr([FromForm] string name, [FromForm] int age,
            [FromForm] Gender gender,
            [FromForm] string email, [FromForm] string password)
        {
            var user = new RegistrationForm(name, age, gender, email, password);
            
            string json = JsonConvert.SerializeObject(user);

            using (StreamWriter writer = new StreamWriter("Users.json", true))
            {
                writer.WriteLineAsync(json);
            }

            return View("Privacy");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}