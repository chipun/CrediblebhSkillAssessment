using System;
using System.Linq;
using System.Web.Mvc;
using Credible.WebApp.DAL;
using Credible.WebApp.Repositories;

namespace Credible.WebApp.Controllers
{
    public class RegistrationsController : Controller
    {
        readonly CourseRepository courseRepoistory = new CourseRepository(new CourseContext());
        readonly RegistrationRepository registrationRepository = new RegistrationRepository(new RegistrationContext());
        private int _course_portal_id { get; set; } 


        public ActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Details(int id)
        {
            _course_portal_id = id;
            var course = courseRepoistory.SelectById(id);
            var UsersRegistredByCourse = registrationRepository.SelectSomeByPortalId(id);

            ViewBag.Course = course;
            
            return View (UsersRegistredByCourse);
        }


        //public ActionResult Details(string sortOrder, string q, int page = 1, int pageSize = 2)
        //{
        //    ViewBag.searchQuery = String.IsNullOrEmpty(q) ? "" : q;

        //    page = page > 0 ? page : 1;
        //    pageSize = pageSize > 0 ? pageSize : 25;

        //    ViewBag.FirstNameSortParam = sortOrder == "firstName" ? "firstname_desc" : "firstName";
        //    ViewBag.LastNameSortParma = sortOrder == "lastName" ? "lastname_desc" : "lastName";

        //    ViewBag.CurrentSort = sortOrder;


        //    var query = registrationRepository.SelectSomeByPortalId(_course_portal_id);

        //    switch (sortOrder)
        //    {
        //        case "firstName":
        //            query = (System.Collections.Generic.ICollection<Credible.WebApp.Models.RegistratedUser>)query.OrderBy(x => x.user.first_nm);
        //            break;
        //        case "lastName":
        //            query = (System.Collections.Generic.ICollection<Credible.WebApp.Models.RegistratedUser>)query.OrderBy(x => x.user.last_nm);
        //            break;
        //        case "firstname_desc":
        //            query = (System.Collections.Generic.ICollection<Credible.WebApp.Models.RegistratedUser>)query.OrderByDescending(x => x.user.first_nm);
        //            break;
        //        case "lastname_desc":
        //            query = (System.Collections.Generic.ICollection<Credible.WebApp.Models.RegistratedUser>)query.OrderByDescending(x => x.user.last_nm);
        //            break;
        //        default:
        //            break;
        //    }


        //    ViewBag.RegisteredUsersByCourse = query;


        //    return View();
        //}

        public ActionResult Create()
        {
            return View ();
        } 

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }
        
        public ActionResult Edit(int id)
        {
            return View ();
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }

        public ActionResult Delete(int id)
        {
            return View ();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }
    }
}