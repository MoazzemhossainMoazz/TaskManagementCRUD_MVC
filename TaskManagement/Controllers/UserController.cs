using Microsoft.AspNetCore.Mvc;
using TaskManagement.Data;

namespace TaskManagement.Controllers
{
    public class UserController : Controller
    {
        private readonly TaskContextData _dbContext;

        public UserController(UserController dbContext)
        {
            _dbContext = dbContext;
        }

        public ActionResult Index()
        {
            var model = _dbContext.Users.OrderBy(x => x.Id);
            return View(model);
        }
    }
}
