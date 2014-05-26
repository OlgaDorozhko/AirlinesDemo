namespace AirlinesDemo.Controllers
{
    using System.Web.Mvc;
    using Services.Interfaces;

    public class HomeController : Controller
    {
        private readonly IFlightService _flightService;

        public HomeController(IFlightService flightService)
        {
            _flightService = flightService;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
