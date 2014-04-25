using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lecture06.Models
{
    public class Book
    {
        public string BookTitle { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }

        public override string ToString()
        {
            return BookTitle + " " + Author + " " + (IsAvailable ? "Available" : "Not available");
        }
    }
}