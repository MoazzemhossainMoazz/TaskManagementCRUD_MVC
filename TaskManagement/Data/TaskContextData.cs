using Microsoft.EntityFrameworkCore;
using TaskManagement.Controllers;
using TaskManagement.Models;

namespace TaskManagement.Data
{
    public class TaskContextData : DbContext
    {
        //public DbSet<EmployeeModels> Employees { get; set; }
        public TaskContextData(DbContextOptions<TaskContextData> op) : base(op)
        {

        }
        public DbSet<TaskInfoModels> Tasks { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<AssignTaskModels> AssignTasks { get; set; }
        public DbSet<DepartmentModels> Departments { get; set; }
        public DbSet<SubjectModels> Subjects { get; set; }

        public static implicit operator TaskContextData(TaskInfoController v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator TaskContextData(UserController v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator TaskContextData(AssignController v)
        {
            throw new NotImplementedException();
        }
    }
}
