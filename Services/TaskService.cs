using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaskTracker.Models;

namespace TaskTracker.Services
{
    public class TaskService
    {
        private readonly TaskContext _context;

        public TaskService(TaskContext context)
        {
            _context = context;
        }

        public async Task<List<TaskTracker.Models.Task>> GetTasksAsync()
        {
            return await _context.Tasks.ToListAsync();
        }

        public async Task<TaskTracker.Models.Task?> GetTaskByIdAsync(int id)
        {
            return await _context.Tasks.FindAsync(id);
        }

        public async Task<TaskTracker.Models.Task> CreateTaskAsync(TaskTracker.Models.Task task)
        {
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();
            await _context.Entry(task).GetDatabaseValuesAsync(); // Get DB generated values
            return task;
        }

        // ... Add UpdateTaskAsync and DeleteTaskAsync methods ...
    }
}
