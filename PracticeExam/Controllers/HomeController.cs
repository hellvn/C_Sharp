using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PracticeExam.Context;
using PracticeExam.Models;

namespace PracticeExam.Controllers
{
    public class HomeController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Home
        public ActionResult Index()
        {
            var exams = db.Exams.Include(e => e.ClassRoom).Include(e => e.Faculty).Include(e => e.Subject);
            return View(exams.ToList());
        }

        // GET: Home/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exam exam = db.Exams.Find(id);
            if (exam == null)
            {
                return HttpNotFound();
            }
            return View(exam);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            ViewBag.ClassRoomId = new SelectList(db.ClassRooms, "Id", "Name");
            ViewBag.FacultyId = new SelectList(db.Faculties, "Id", "Name");
            ViewBag.SubjectId = new SelectList(db.Subjects, "Id", "Name");
            return View();
        }

        // POST: Home/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,SubjectId,StartTime,ExamDate,ExamDuration,ClassRoomId,FacultyId,Status")] Exam exam)
        {
            if (ModelState.IsValid)
            {
                db.Exams.Add(exam);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ClassRoomId = new SelectList(db.ClassRooms, "Id", "Name", exam.ClassRoomId);
            ViewBag.FacultyId = new SelectList(db.Faculties, "Id", "Name", exam.FacultyId);
            ViewBag.SubjectId = new SelectList(db.Subjects, "Id", "Name", exam.SubjectId);
            return View(exam);
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exam exam = db.Exams.Find(id);
            if (exam == null)
            {
                return HttpNotFound();
            }
            ViewBag.ClassRoomId = new SelectList(db.ClassRooms, "Id", "Name", exam.ClassRoomId);
            ViewBag.FacultyId = new SelectList(db.Faculties, "Id", "Name", exam.FacultyId);
            ViewBag.SubjectId = new SelectList(db.Subjects, "Id", "Name", exam.SubjectId);
            return View(exam);
        }

        // POST: Home/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,SubjectId,StartTime,ExamDate,ExamDuration,ClassRoomId,FacultyId,Status")] Exam exam)
        {
            if (ModelState.IsValid)
            {
                db.Entry(exam).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ClassRoomId = new SelectList(db.ClassRooms, "Id", "Name", exam.ClassRoomId);
            ViewBag.FacultyId = new SelectList(db.Faculties, "Id", "Name", exam.FacultyId);
            ViewBag.SubjectId = new SelectList(db.Subjects, "Id", "Name", exam.SubjectId);
            return View(exam);
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exam exam = db.Exams.Find(id);
            if (exam == null)
            {
                return HttpNotFound();
            }
            return View(exam);
        }

        // POST: Home/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Exam exam = db.Exams.Find(id);
            db.Exams.Remove(exam);
            db.SaveChanges();
            return RedirectToAction("Index");
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
}
