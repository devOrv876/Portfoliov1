using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfoliov1.Models;

namespace Portfoliov1.Controllers
{
    public class HomeController : Controller

    {


        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult CV()
        {
            CvViewModel model = new CvViewModel();

            using (CVDataModelContext cvData = new CVDataModelContext())
            {

                model.personalStatements = cvData.personalStatements.ToList();

                model.educationLevels = cvData.educationLevels.ToList();
                model.institutions = cvData.institutions.ToList();
                model.qualifications = cvData.qualifications.ToList();

                model.interestes = cvData.interestes.ToList();
                model.experiences = cvData.experiences.ToList();

                model.CVReferences1 = cvData.CVReferences1.ToList();
            }               

                return View(model);
        }


        public ActionResult CVEdit()
        {
            return View();
        }

       
        [HttpPost]
        public ActionResult CVEdit(CvViewModel model)
        {
            CvViewModel model1 = new CvViewModel();

            using (CVDataModelContext cvData = new CVDataModelContext())

            {

                //UPDATE METHOD HERE
            }

            return RedirectToAction("CV", "Home");
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