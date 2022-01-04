using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using Scenarios.Model;
using Scenarios.Services;

namespace Scenarios.ViewModels.Sample04
{
    public class ListsViewModel : Scenarios.ViewModels.MasterPageViewModel
    {
        private readonly TasksService tasksService;


        public List<TaskModel> Tasks { get; set; }

        public string NewTask { get; set; }

        public ListsViewModel(TasksService tasksService)
        {
            this.tasksService = tasksService;
        }

        public override Task PreRender()
        {
            Tasks = tasksService.GetTasks();
            return base.PreRender();
        }

        public void AddTask()
        {
            tasksService.AddTask(NewTask);
        }

        public void CompleteTask(TaskModel task)
        {
            tasksService.SetCompleted(task.Id);
        }
    }
}

