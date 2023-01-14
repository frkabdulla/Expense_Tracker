using EFCodeFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFCodeFirstApproach.Controllers
{
    public class limitController : Controller
    {
        expanseContext db = new expanseContext();
        // GET: Home
        public ActionResult Index()
        {
            var data = db.expanses.ToList();
            return View(data);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(expanse s)
        {


            if (ModelState.IsValid == true)
            {
                db.expanses.Add(s);
                int a = db.SaveChanges();
                if (a > 0)
                {

                    //ViewBag.InsertMessage = "<script> alert('Data Inserted') </script>";
                    Session["InsertMessage"] = "<script> alert('Data Inserted')       </script>";
                    return RedirectToAction("Index", "Home");
                    // ModelState.Clear();
                }
                else
                {
                    ViewBag.InsertMessage = "<script> alert('Data NOT Inserted')      </script>";
                }
            }

            return View();
        }
        public ActionResult Edit(int id)
        {
            var row = db.expanses.Where(model => model.Id == id).FirstOrDefault();
            return View(row);
        }

        [HttpPost]
        public ActionResult Edit(expanse s)
        {
            if (ModelState.IsValid == true)
            {
                db.Entry(s).State = EntityState.Modified;
                int a = db.SaveChanges();
                if (a > 0)
                {
                    TempData["UpdateMessage"] = "<script> alert('Data Update !!')</script>";
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["UpdateMessage"] = "<script> alert('Data not update')</script>";
                }
            }
            return View(s);
        }
    }
}
       
