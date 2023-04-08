using Crm.Models;

namespace Crm.Services.Impl
{
    public class TaskService : ITaskService
    {
        public async Task<IEnumerable<TaskModel>> GetAllTasksAsync()
        {
            return new List<TaskModel>
            {
                new TaskModel { Id = 1, Name = "Task 1"},
                new TaskModel { Id = 2, Name = "Task 2"}
            };
        }
    }
}