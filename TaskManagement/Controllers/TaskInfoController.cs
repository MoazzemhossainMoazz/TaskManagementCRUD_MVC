using Microsoft.AspNetCore.Mvc;
using TaskManagement.Data;
using System.Linq;
using TaskManagement.Models;

namespace TaskManagement.Controllers
{
    public class TaskInfoController : Controller
    {
        private readonly TaskContextData _dbContext;

        public TaskInfoController(TaskContextData dbContext)
        {
            _dbContext = dbContext;
        }

        public ActionResult Index()
        {
            var model = _dbContext.Tasks.OrderBy(x => x.Id).ToList();
            return View(model);
        }

        public ActionResult Delete(int id)
        {
            var task = _dbContext.Tasks.Find(id);
            _dbContext.Tasks.Remove(task);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(TaskInfoModels taskInfoModels)
        {

            _dbContext.Tasks.Add(taskInfoModels);
            if(_dbContext.SaveChanges()>0)
            { return RedirectToAction("Index"); }

            return View(taskInfoModels);
        }
    }
}
