using AtivarPortugalScheduler.DAL;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace AtivarPortugalScheduler.Controllers
{
    public class StartupMeetingsController : Controller
    {
        private SpeedDatingContext db = new SpeedDatingContext();

        // GET: Meetings
        public ActionResult Index()
        {
            var Code = (string)Session["StartupCode"];
            var meetings = db.Meetings.Include(m => m.Company).Include(m => m.Room).Include(m => m.StartupM).AsEnumerable().Where(m => m.StartupM.Code == Code).OrderBy(m => m.MeetingTime);
            if (meetings.Count() == 0)
            {
                TempData["StartupError"] = "Introduza um código válido";
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