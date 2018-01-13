using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Controllers;
using Orchard;
using Orchard.Themes;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.Blockchain.Web.Controllers
{
    [Themed]
    public class HomeController : BaseController
    {
        //
        // GET: /EleWise.ELMA.Blockchain.Web/
        [ContentItem(Name = "Blockchain", Image32 = RouteProvider.ImagesFolder + "x32/leftmenu.png")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
