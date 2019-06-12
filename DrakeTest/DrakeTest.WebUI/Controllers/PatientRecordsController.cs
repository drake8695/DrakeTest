using DrakeTest.Core.Contracts;
using DrakeTest.Core.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DrakeTest.WebUI.Controllers
{
    [Authorize]
    public class PatientRecordsController : Controller
    {
       
        IRepository<Patient> patient;
        IRepository<PatientRecords> patientrecords;
        public PatientRecordsController(IRepository<Patient> Patient, IRepository<PatientRecords> PatientRecords)
        {
            patient = Patient;
            patientrecords = PatientRecords;
        }
        // GET: PatientRecords
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            List<PatientRecords> patientRecords = patientrecords.Collection().Where(p => p.UserId == userId).OrderBy(c => c.CreatedAt).ToList();
            return View(patientRecords);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PatientRecords patientRecords)
        {
            if (!ModelState.IsValid)
            {
                return View(patientRecords);
            }
            else
            {
                PatientRecords patientRecords_temp = new PatientRecords()
                {
                    UserId = User.Identity.GetUserId(),
                    height = patientRecords.height,
                    weight = patientRecords.weight,
                    test = patientRecords.test
                };

                patientrecords.Insert(patientRecords_temp);
                patientrecords.Commit();
                return RedirectToAction("Index");
            }

        }

        public ActionResult Edit(string Id)
        {
            PatientRecords patientRecordsToEdit = patientrecords.Find(Id);
            if (patientRecordsToEdit == null)
            {
                return HttpNotFound();
            }
            else
            {
                
              
                return View(patientRecordsToEdit);
            }
        }
        [HttpPost]
        public ActionResult Edit(PatientRecords patientRecords, string Id)
        {
            PatientRecords patientRecordsToEdit = patientrecords.Find(Id);

            if (patientRecordsToEdit == null)
            {
                return HttpNotFound();
            }
            else
            {
                if (!ModelState.IsValid)
                {
                    return View(patientRecordsToEdit);
                }

                patientRecordsToEdit.height = patientRecords.height;
                patientRecordsToEdit.weight = patientRecords.weight;

                patientRecordsToEdit.test = patientRecords.test;
               

                patientrecords.Commit();
                return RedirectToAction("Index");
            }
        }
       
        
        public ActionResult Delete(string Id)
        {
            PatientRecords patientRecordsToDelete = patientrecords.Find(Id);
            if (patientRecordsToDelete == null)
            {
                return HttpNotFound();
            }
            else
            {
                patientrecords.Delete(Id);
                patientrecords.Commit();
                return RedirectToAction("Index");
            }
        }


    }
}