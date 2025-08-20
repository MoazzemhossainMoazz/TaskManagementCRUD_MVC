using Microsoft.AspNetCore.Mvc;
using TaskManagement.Data;
using TaskManagement.Models;

namespace TaskManagement.Controllers
{
    public class SubjectsController : Controller
    {
        private readonly TaskContextData _dbContext;

        public SubjectsController(TaskContextData dbContext)
        {
            _dbContext = dbContext;
        }

        public ActionResult SubjectIndex()
        {
            var model = _dbContext.Subjects.OrderBy(x => x.Id).ToList();
            return View(model);
        }

        public ActionResult SubjectDetails(int Id)
        {
            var Department = _dbContext.Subjects.Find(Id);
            return View(Department);
        }

        public ActionResult SubjectDelete(int Id)
        {
            var subject = _dbContext.Subjects.Find(Id);
            if(subject != null)
            {
                _dbContext.Subjects.Remove(subject);
                _dbContext.SaveChanges();
            }
            return RedirectToAction("SubjectIndex");
        }

        public ActionResult SubjectCreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SubjectCreate(SubjectModels subjectModels)
        {
            _dbContext.Subjects.Add(subjectModels);
            if(_dbContext.SaveChanges() > 0)
            {
                return RedirectToAction("SubjectIndex");
            }
            return View(subjectModels);
        }

        public ActionResult SubjectEdit(int Id)
        {
            var subject = _dbContext.Subjects.Find(Id);
            return View(subject);
        }

        [HttpPost]
        public ActionResult SubjectEdit(SubjectModels subjectModels)
        {
            _dbContext.Subjects.Update(subjectModels);
            if(_dbContext.SaveChanges() > 0)
            {
                return RedirectToAction("SubjectIndex");
            }
            return View(subjectModels);
        }

    }
}
