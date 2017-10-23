﻿using ClientFeatures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClientFeatures.Controllers {
    public class HomeController : Controller {
        public ViewResult MakeBooking() {
            return View(new Appointment {
                ClientName = "Adam",
                Date = DateTime.Now.AddDays(2),
                TermsAccepted = true
            });
        }
        [HttpPost]
        public JsonResult MakeBooking(Appointment appt) {
            return Json(appt, JsonRequestBehavior.AllowGet);
        }
    }
}