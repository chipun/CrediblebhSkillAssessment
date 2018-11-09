using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Credible.WebApp.DAL;
using Credible.WebApp.Models;
using Credible.WebApp.Repositories;

namespace Credible.WebApp.Controllers
{
    public class HomeController : Controller
    {
        readonly ClientRepository repository = new ClientRepository(new ClientContext());

        public ActionResult Index()
        {
            var clientRecords = repository.SelectAll();
            
            return View(clientRecords);
        }

    }
}
