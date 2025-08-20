using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using TaskManagement.Data;
using TaskManagement.Models;

namespace TaskManagement.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly TaskContextData _dbContext;

        public DepartmentController(TaskContextData dbContext)
        {
            _dbContext = dbContext;
        }

        public ActionResult DepartmentIndex()
        {
            var model = _dbContext.Departments.OrderBy(x => x.Id).ToList();
            return View(model);
        }

        public ActionResult DepartmentDetails(int id)
        {
            var department = _dbContext.Departments.Find(id);
            return View(department);
        }

        public ActionResult DepartmentDelete(int id)
        {
            var department = _dbContext.Departments.Find(id);
            if(department != null)
            {
                _dbContext.Departments.Remove(department);
                _dbContext.SaveChanges();
            }
            return RedirectToAction("DepartmentIndex");
        }

        public ActionResult DepartmentCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DepartmentCreate(DepartmentModels departmentModels)
        {
            _dbContext.Departments.Add(departmentModels);
            if(_dbContext.SaveChanges() > 0)
            {
                return RedirectToAction("DepartmentIndex");
            }
            return View(departmentModels);
        }

        public ActionResult DepartmentEdit(int id)
        {
            var department = _dbContext.Departments.Find(id);
            return View(department);
        }

        [HttpPost]
        public ActionResult DepartmentEdit(DepartmentModels departmentModels)
        {
            _dbContext.Departments.Update(departmentModels);
            if(_dbContext.SaveChanges() > 0)
            {
                return RedirectToAction("DepartmentIndex");
            }
            return View(departmentModels);
        }


    }
}
