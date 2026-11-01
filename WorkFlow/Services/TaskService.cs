using WorkFlow.Models;

namespace WorkFlow.Services
{
    public class TaskService
    {

        //список задач
        private List<TaskItem> _tasks = new List<TaskItem>();

        //идентификатор следующей задачи
        private int _nextId = 1;



        //добавляем задачу в список задач
        public void AddTask(TaskItem task)
        {
            task.Id = _nextId;
            _nextId = _nextId + 1;
            _tasks.Add(task);
        }

        //получаем количество задач
        public int GetTaskCount() => _tasks.Count;


        //получаем id задачи
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
        //удаляем задачу
        public void RemoveTask(int id)
        {
            TaskItem taskRemove = GetTaskById(id);

            if (taskRemove != null)
                _tasks.Remove(taskRemove);
        }


    }
}
