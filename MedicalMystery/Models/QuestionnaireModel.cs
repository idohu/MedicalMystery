using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MedicalMystery.Models
{
    public class QuestionnaireModel
    {
        [Display(Name = "Questionnaire ID")]
        public string QuestionnaireID;

        [Display(Name = "Questionnaire ID")]
        public string QuestionnaireName;

        public string QuestionnaireDescription;

        [Display(Name = "Questionnaire ID")]
        public DateTime QuestionnaireStartDate;

        [Display(Name = "Questionnaire ID")]
        public DateTime QuestionaireEndDate;

        public string Doctor;
    }
}