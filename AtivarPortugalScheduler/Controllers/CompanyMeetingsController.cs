using AtivarPortugalScheduler.DAL;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace AtivarPortugalScheduler.Controllers
{
    public class CompanyMeetingsController : Controller
    {
        private SpeedDatingContext db = new SpeedDatingContext();

        // GET: Meetings
        public ActionResult Index()
        {
            var Code = (string)Session["CompanyCode"];
            var meetings = db.Meetings.Include(m => m.Company).Include(m => m.Room).Include(m => m.StartupM).AsEnumerable().Where(m => m.Company.Code == Code).OrderBy(m => m.MeetingTime);
            if(meetings.Count() == 0)
            {
                TempData["CompanyError"] = "Introduza um código válido";
                return new RedirectResult("Home");
            }
            return View(meetings.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}