using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lecture09.Models
{
    public class Appointment
    {
        public string ClientName { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public bool TermsAccepted { get; set; }

        public static IEnumerable<Appointment> GetAppointments()
        {
            yield return new Appointment { ClientName = "John", Date = new DateTime(2010, 7, 7) };
            yield return new Appointment { ClientName = "John", Date = new DateTime(2010, 8, 8) };
            yield return new Appointment { ClientName = "John", Date = new DateTime(2010, 9, 9) };
            yield return new Appointment { ClientName = "Jane", Date = new DateTime(2010, 10, 10) };
            yield return new Appointment { ClientName = "Jane", Date = new DateTime(2010, 11, 11) };
        }
    }
}