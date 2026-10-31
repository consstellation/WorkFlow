using WorkFlow.Models;

namespace WorkFlow.Services
{
    public class TaskService
    {
        private List<TaskItem> _tasks = new List<TaskItem>();

        public void AddTask(TaskItem task)
        {
            _tasks.Add(task);
        }

        public int GetTaskCount() => _tasks.Count;

        public TaskItem GetTaskById(int id)
        {
            foreach (TaskItem task in _tasks)
            {
                if(task.Id == id)
                    return task;

            }

            return null;
        }
        //Коллекцию нельзя изменять во время обычного перебора через foreach.
        public void RemoveTask(int id)
        {
            TaskItem taskRemove = GetTaskById(id);

            if (taskRemove != null)
                _tasks.Remove(taskRemove);
        }


    }
}
