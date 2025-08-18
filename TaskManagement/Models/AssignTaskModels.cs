using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagement.Models
{
    public class AssignTaskModels
    {
        public int Id { get; set; }
        public int Taskid { get; set; }
        public int UserId { get; set; }
        public DateTime SubmitDate { get; set; }
        public DateTime DueDate { get; set; }
        public string? Remark { get; set; }
        public TaskInfoModels TaskModels { get; set; }
        public UserModel UserModels { get; set; }
    }
}
