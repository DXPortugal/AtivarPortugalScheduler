using System.Web.Mvc;

namespace AtivarPortugalScheduler.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.StartupError = TempData["StartupError"];
            ViewBag.CompanyError = TempData["CompanyError"];
            return View();
        }

        [HttpPost]
        public RedirectResult Index(string StartupCode, string CompanyCode)
        {
            Session["StartupCode"] = StartupCode;
            Session["CompanyCode"] = CompanyCode;
            if (string.IsNullOrEmpty(StartupCode))
            {
                if (string.IsNullOrEmpty(CompanyCode))
                {
                }
                else
                {
                    return new RedirectResult("CompanyMeetings");
                }
            }
            else
            {
                return new RedirectResult("StartupMeetings");
            }

            return new RedirectResult("Home");
        }
    }
}