// Controllers/TaskController.cs
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TaskTracker.Services;

public class TaskController : Controller
{
    private readonly TaskService _taskService;

    public TaskController(TaskService taskService)
    {
        _taskService = taskService;
    }

    public async Task<IActionResult> Index()
    {
        var tasks = await _taskService.GetTasksAsync();
        return View(tasks);
    }

    // ... Add actions for Create, Edit, Delete ...
}