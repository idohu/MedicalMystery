using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MedicalMystery.Models;
using Microsoft.Ajax.Utilities;
using NQualtrics.Core;

namespace MedicalMystery.Controllers
{
    public class HomeController : Controller
    {
        List<string> names = new List<string>()
        {
            "Clinical Fibromyalgia Diagnostic",
            "Questionnaire for patients with Recurrent aphthous stomatitis",
            "Demographic and clinical characteristics of patients in an orofacial pain tertiary clinic",
            "Basic Questionnaire for Pain Clinic Paitents"
        };
        public ActionResult Index()
        {
            //Get Top Questionnaires
            //Add Them To Model
            List<QuestionnaireModel> l = new List<QuestionnaireModel>();
            for (int i = 0; i < 4; i++)
            {
                l.Add(new QuestionnaireModel
                {
                    QuestionaireEndDate = DateTime.Now.AddDays(2),
                    QuestionnaireID = i.ToString(),
                    QuestionnaireName = names[i],
                    QuestionnaireStartDate = DateTime.Now.AddDays(-Math.Pow(i, 3)),
                    Doctor = (i % 2 == 0) ? "Dr. Galit Almoznino DMD, M.Sc., MHA," : "Prof. Yuval Shahar, MD, PhD, FACMI",
                    QuestionnaireDescription = "bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla" +
                                               "bla bla bla bla bla bla bla bla bla bla bla bla bla bla blabla bla bla bla bla bla bla" +
                                               " bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla"
                });
            }
            ViewBag.Questionnaires = l;
            // return View("DoctorDashboard");
            if (User.Identity.IsAuthenticated)
            {
                if (User.IsInRole("User"))
                    return View("UserDashboard");
                if (User.IsInRole("Doctor"))
                    return View("DoctorDashboard");
                if (User.IsInRole("Admin"))
                    return View("AdminDashboard");
            }

            return View();


        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}