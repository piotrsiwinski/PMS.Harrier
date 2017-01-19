using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PMS.Harrier.DataAccessLayer.Concrete;
using PMS.Harrier.DataAccessLayer.Models;

namespace PMS.Harrier.WebUI.Controllers
{
    public class IssuesController : Controller
    {
        private EfDbContext db = new EfDbContext();

        // GET: Issues
        public ActionResult Index(int? id)
        {
            IEnumerable<Issue> issues  = db.Issues.Include(i => i.Developer).Include(i => i.Project);
            if (id.HasValue)
            {
                issues = issues.Where(i => i.Project.ProjectId == id.Value);
            }
            
            return View(issues.ToList());
        }

        // GET: Issues/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Issue issue = db.Issues.Find(id);
            if (issue == null)
            {
                return HttpNotFound();
            }
            return View(issue);
        }

        // GET: Issues/Create
        public ActionResult Create()
        {
            ViewBag.DeveloperId = new SelectList(db.Developers, "DeveloperId", "ExperienceFromDate");
            ViewBag.ProjectId = new SelectList(db.Projects, "ProjectId", "ProjectName");
            return View();
        }

        // POST: Issues/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IssueId,ProjectId,DeveloperId,Reporter,Title,Description,LoggedHours,SolutionDescription")] Issue issue)
        {
            if (ModelState.IsValid)
            {
                db.Issues.Add(issue);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DeveloperId = new SelectList(db.Developers, "DeveloperId", "ExperienceFromDate", issue.DeveloperId);
            ViewBag.ProjectId = new SelectList(db.Projects, "ProjectId", "ProjectName", issue.ProjectId);
            return View(issue);
        }

        // GET: Issues/Edit/5
        public ActionResult LogTime(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Issue issue = db.Issues.Find(id);
            if (issue == null)
            {
                return HttpNotFound();
            }
            ViewBag.DeveloperId = new SelectList(db.Developers, "DeveloperId", "ExperienceFromDate", issue.DeveloperId);
            ViewBag.ProjectId = new SelectList(db.Projects, "ProjectId", "ProjectName", issue.ProjectId);
            return View(issue);
        }

        // POST: Issues/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogTime([Bind(Include = "IssueId,ProjectId,DeveloperId,Reporter,Title,Description,LoggedHours,SolutionDescription")] Issue issue)
        {
            if (ModelState.IsValid)
            {
                db.Entry(issue).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DeveloperId = new SelectList(db.Developers, "DeveloperId", "ExperienceFromDate", issue.DeveloperId);
            ViewBag.ProjectId = new SelectList(db.Projects, "ProjectId", "ProjectName", issue.ProjectId);
            return View(issue);
        }

        // GET: Issues/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Issue issue = db.Issues.Find(id);
            if (issue == null)
            {
                return HttpNotFound();
            }
            return View(issue);
        }

        // POST: Issues/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Issue issue = db.Issues.Find(id);
            db.Issues.Remove(issue);
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
