using Microsoft.AspNetCore.Mvc;
using TaskManagement.Data;

namespace TaskManagement.Controllers
{
    public class AssignController : Controller
    {
        private readonly TaskContextData _dbContext;

        public AssignController(TaskContextData dbContext)
        {
            _dbContext = dbContext;
        }

        public ActionResult Index()
        {
            var model = _dbContext.AssignTasks.OrderBy(x => x.Id).ToList();
            return View(model);
        }
    }
}
