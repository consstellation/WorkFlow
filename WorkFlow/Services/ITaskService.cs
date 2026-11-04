using WorkFlow.Models;

namespace WorkFlow.Services
{
    public interface ITaskService
    {
        public void AddTask(TaskItem task);
        public int GetTaskCount();
        public TaskItem? GetTaskById(int id);
        public bool RemoveTask(int id);

    }
}
