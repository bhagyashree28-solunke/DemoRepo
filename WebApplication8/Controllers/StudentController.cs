using Rotativa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        StudentDBContext db = new StudentDBContext();
        public ActionResult Index()
        {

            StudentDbHelper studDb = new StudentDbHelper();
            List<studInfo> list = studDb.GetStudInfo();

            return View(list);
        }

        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AdmissionNumber,StudentName,Nationality,MotherTongue,Religion,Caste,subCaste,BirthPlace,DateOfBirth,DateOfBirthInWords,PrevSchoolName,AdmittedInClass,AdmissionDate,Progress,Behaviour,DateOfSchoolLeaving,ClassFromLeft,CertRecDate,ReceivedBy")] studInfo studDb)
        {
            if (ModelState.IsValid)
            {
                db.studInfoes.Add(studDb);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studDb);
        }

        public  ActionResult PrintId(int?id)
        {
            StudentDbHelper studDb = new StudentDbHelper();
            var data = studDb.GetStudInfo().ToList();
            var stud1 = data.Where(s => s.AdmissionNumber == id).FirstOrDefault();
            return View(stud1);
        }
        public ActionResult PrintPdfDetails(int id)
        {
            var report = new ActionAsPdf("PrintId", new { id = id });
            return report;
        }
    }
}