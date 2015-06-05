using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApiDoc.Models;

namespace ApiDoc.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            List<IApiDoc> apiDocs = new List<IApiDoc>();
            apiDocs = ApiDocReporter.LoadHtmlApiDocFromFolder(Server.MapPath("~/ApiHtml/ApiDoc"));
            return View(apiDocs);
        }

    }
}
