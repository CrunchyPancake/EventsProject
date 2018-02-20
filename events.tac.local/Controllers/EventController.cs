using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using events.tac.local.Models;
using Glass.Mapper.Sc.Web.Mvc;

namespace events.tac.local.Controllers
{
    public class EventController : GlassController
    {
        // GET: Event
        override
        public ActionResult Index()
        {
            return View(GetDataSourceItem<IEventDetailsList>());
        }
    }
}