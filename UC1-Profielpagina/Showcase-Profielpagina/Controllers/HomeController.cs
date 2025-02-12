using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Showcase_Profielpagina.Models;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace Showcase_Profielpagina.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HttpClient _httpClient;

        public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;

            _httpClient = httpClientFactory.CreateClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7101");
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                string responseContent = await _httpClient.GetStringAsync("/Students");

                return View(JsonConvert.DeserializeObject<List<string>>(responseContent));
            }
            catch (HttpRequestException ex)
            {
                ViewBag.ErrorMessage = "verbinden met api is niet gelukt";
            }
            return View(new List<string>());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
