using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyHowest;

namespace DotNetCoreMVCVoorbeeld.Controllers
{
    public class HomeController : Controller
    {
        private string[] groenten = { "rode kool", "spruitjes", "wortel", "spinazie" };

        public ViewResult Index(string name)
        {
            ViewBag.Groet = DateTime.Now.Hour < 12 ? "Goeiemorgen" : "Goeienamiddag";
            return View();
        }

        public ViewResult Groenten(string zoekGroente)
        {
            ViewBag.Groenten = groenten;
            if (!string.IsNullOrEmpty(zoekGroente)) {
                ViewBag.ZoekResultaat = $"de gezochte groente is de {Array.IndexOf(groenten, zoekGroente) + 1}e uit de lijst";

            }
            
            return View();
        }

        public ViewResult Student()
        {
            List<Student> studenten = new List<Student>
            {
                new Student{id = 1, Naam = "Jef", AfstudeerGraad=Graad.Voldoening },
                new Student{id = 2, Naam = "Bart", AfstudeerGraad=Graad.Onderscheiding },
            };

            ViewBag.Studenten = studenten;
            return View();
        }
    }
}