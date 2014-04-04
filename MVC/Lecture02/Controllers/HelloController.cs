using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lecture01.Models;
using System.Drawing;
using System.IO;

namespace Lecture01.Controllers
{
    public class HelloController : Controller
    {

        public string String()
        {
            return "Hello, MVC!";
        }


        public string RedirectedPage()
        {
            return "Redirected here"; 
        }


        public RedirectResult Redirect()
        {
            return Redirect("/Hello/RedirectedPage");
            //return new RedirectResult("/Hello/RedirectedPage");
        }



        public FileContentResult File()
        {
            return File(
                System.Text.Encoding.UTF8.GetBytes("Hello, file!"),
                "bin/bin");

        }

        public FileContentResult Image()
        {
            var bmp = new Bitmap(100, 100);
            using (var g = Graphics.FromImage(bmp))
            {
                g.DrawLine(Pens.Black, 0, 0, 100, 100);
                g.DrawLine(Pens.Black, 100, 0, 0, 100);
            }
            var ms = new MemoryStream();
            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return File(ms.ToArray(), "image/png");
        }


        public ViewResult Page()
        {
            return View();
        }

        public ViewResult PageAgain()
        {
            return View("Page");
        }

        public ViewResult Model()
        {
            var db = new DataBase();
            return View(db.GetDepartments());
        }
    }
}
