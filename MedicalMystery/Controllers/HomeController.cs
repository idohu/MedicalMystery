using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MedicalMystery.Models;
using NQualtrics.Core;

namespace MedicalMystery.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Get Top Questionnaires
            //Add Them To Model
            List<QuestionnaireModel> l = new List<QuestionnaireModel>();
            for (int i = 0; i < 5; i++)
            {
                l.Add(new QuestionnaireModel
                {
                    QuestionaireEndDate = DateTime.Now.AddDays(2),
                    QuestionnaireID = i.ToString(),
                    QuestionnaireName = "Testing this "+i,
                    QuestionnaireStartDate = DateTime.Now.AddDays(-Math.Pow(i,3)),
                    Doctor = (i%2==0)?"Dr. Galit Almoznino DMD, M.Sc., MHA,": "Prof. Yuval Shahar, MD, PhD, FACMI",
                    QuestionnaireDescription = "Just Do It!"
                });
            }
            ViewBag.Questionnaires = l;
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