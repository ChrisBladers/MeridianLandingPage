
using System.Web.Mvc;
using DataResponses;
using Meridian.Services.Interfaces;

namespace Meridian.Controllers
{
    public class HomeController : Controller
    {

        private readonly IHomeService _homeService;
        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult GetContactDetails()
        {
            var contactDetails = _homeService.GetContactDetails();
            return new DataResponse(contactDetails).Result();
        }

        public ActionResult GetBanner()
        {
            var banner = _homeService.GetBanner();
            return new DataResponse(banner).Result();
        }

        public ActionResult GetHangBanners()
        {
            var hangBanners = _homeService.GetHangBanners();
            return new DataResponse(hangBanners).Result();
        }
    }
}