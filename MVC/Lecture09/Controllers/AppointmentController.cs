using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lecture09.Models;

namespace Lecture09.Controllers
{
    public class AppointmentController : Controller
    {
        //
        // GET: /Appointment/
        string ViewName="Index5";

        public ActionResult Index(string clientName)
        {
            return View(ViewName,(object)clientName);
        }


        public ActionResult AppointmentData(string clientName)
        {
            var data = Appointment.GetAppointments();
            if (!string.IsNullOrEmpty(clientName) && clientName!="All")
                data=data.Where(z => z.ClientName == clientName);
            return PartialView("AppointmentData",data);
        }

    }
}
