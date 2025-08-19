using Microsoft.AspNetCore.Mvc;
using TaskManagement.Data;
using TaskManagement.Models;

namespace TaskManagement.Controllers
{
    public class UserController : Controller
    {
        private readonly TaskContextData _dbContext;

        public UserController(TaskContextData dbContext)
        {
            _dbContext = dbContext;
        }

        public ActionResult UserIndex()
        {
            var model = _dbContext.Users.OrderBy(x => x.Id);
            return View(model);
        }

        public ActionResult UserDelete(int id)
        {
            var user = _dbContext.Users.Find(id);
            _dbContext.Users.Remove(user);
            _dbContext.SaveChanges();
            return RedirectToAction("UserIndex");
        }

        public ActionResult UserDetails(int id)
        {
            var user = _dbContext.Users.Find(id);
            return View(user);
        }

        public ActionResult UserCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UserCreate(UserModel userModel)
        {
            _dbContext.Users.Add(userModel);
            if (_dbContext.SaveChanges() > 0)
            {
                return RedirectToAction("UserIndex");
            }
            return View(userModel);
        }

        public ActionResult UserEdit(int id)
        {
            var user = _dbContext.Users.Find(id);
            return View(user);
        }

        [HttpPost]
        public ActionResult UserEdit(UserModel userModel)
        {
            _dbContext.Users.Update(userModel);
            if(_dbContext.SaveChanges() > 0)
            {
                return RedirectToAction("UserIndex");
            }
            return View(userModel);
        }

        

    }
}
