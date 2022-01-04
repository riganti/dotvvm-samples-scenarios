using System.Collections.Generic;
using System.Linq;
using Scenarios.Data;
using Scenarios.Model;

namespace Scenarios.Services;

public class TasksService
{
    private readonly AppDbContext appDbContext;

    public TasksService(AppDbContext appDbContext)
    {
        this.appDbContext = appDbContext;
    }

    public List<TaskModel> GetTasks()
    {
        return appDbContext.Tasks
            .Select(t => new TaskModel()
            {
                Id = t.Id,
                Text = t.Text,
                IsCompleted = t.IsCompleted
            })
            .ToList();
    }

    public void SetCompleted(int taskId)
    {
        var appTask = appDbContext.Tasks.Find(taskId);
        appTask.IsCompleted = true;
        appDbContext.SaveChanges();
    }

    public void AddTask(string newTask)
    {
        var appTask = new AppTask() { Text = newTask };
        appDbContext.Tasks.Add(appTask);
        appDbContext.SaveChanges();
    }
}