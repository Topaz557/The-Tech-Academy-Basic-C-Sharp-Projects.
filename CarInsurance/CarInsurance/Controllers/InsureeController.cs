using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;


namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private Database1Entities db = new Database1Entities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Tables.ToList());
        }
        public ActionResult Admin()
        {
            return View(db.Tables.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Table table)
        {
            if (ModelState.IsValid)
            {
                table.Quote = GetQuote(table);
                db.Tables.Add(table);
                
                db.SaveChanges();
                
                return RedirectToAction("Index");
            }

            return View(table);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Table table)
        {
            if (ModelState.IsValid)
            {
                table.Quote = GetQuote(table);
                db.Entry(table).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table table = db.Tables.Find(id);
            db.Tables.Remove(table);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public decimal GetQuote(Table table)
        {
            //Table table = db.Tables.Find(id);
            
            //string FirstName = table.FirstName;
            //string LastName = table.LastName;
            //string EmailAddress = table.EmailAddress;
            DateTime DateOfBirth = table.DateOfBirth;
            int CarYear = table.CarYear;
            string CarMake = table.CarMake;
            string CarModel = table.CarModel;
            bool DUI = table.DUI;
            int SpeedingTickets = table.SpeedingTickets;
            bool CoverageType = table.CoverageType;
            decimal BaseQuote = table.Quote;
            

            
            BaseQuote = 50;
            for (int i = 0; i < SpeedingTickets; i++) // only required for
            {
                BaseQuote += 10;
            }
            if (DateTime.Now.Year - table.DateOfBirth.Year <= 18) // use if for remaining statements, except for the two bools
            {
                BaseQuote += 100;

            }
            if (DateTime.Now.Year - table.DateOfBirth.Year <= 25 && DateTime.Now.Year - table.DateOfBirth.Year >= 19)
            {
                BaseQuote += 50;
            }
            if (DateTime.Now.Year - table.DateOfBirth.Year >= 26)
            {
                BaseQuote += 25;
            }
            if (CarMake == "Porsche")
            {
                BaseQuote += BaseQuote + 25;
                if (CarModel == "911 Carrera")
                {
                    BaseQuote += 25;
                }
            }
            if (CarYear < 2015)
            {
                BaseQuote += 25;
            }
            if (CarYear > 2000)
            {
                BaseQuote += 25;
            }
            if (table.DUI == true)
            {
                BaseQuote += (.25m ) * BaseQuote;
            }
            if (table.CoverageType == true)
            {
                BaseQuote += (0.5m ) * BaseQuote; 
            }

            return BaseQuote;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}// USE ID for finding the quote
