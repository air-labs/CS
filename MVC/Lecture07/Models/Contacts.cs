using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lecture06.Models
{
    public partial class Contacts
    {
        public string Street { get; set; }
        public int House { get; set; }
        public string EMail { get; set; }
        public string Phone { get; set; }
    }
}
