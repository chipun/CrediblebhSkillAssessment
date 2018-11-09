
using System.Linq;
using System.Web.Mvc;
using Credible.WebApp.DAL;
using Credible.WebApp.Models;
using Credible.WebApp.Repositories;

namespace Credible.WebApp.Controllers
{
    public class ClientsController : Controller
    {
        //readonly ClientRepository clientRepository = new ClientRepository();
        readonly CourseRepository courseRepoistory = new CourseRepository(new CourseContext());
        readonly ClientRepository ClientRepoistory = new ClientRepository(new ClientContext());

        public ActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Details(int id)
        {

            var selectedClient = ClientRepoistory.SelectById(id);

            ViewBag.ClientDetail = selectedClient;

            var courseRecords = courseRepoistory.SelectSomeByPortalId(id);

            return View(courseRecords);
        }


    }
}