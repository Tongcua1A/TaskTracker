using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TaskTracker.Models;

namespace TaskTracker.Models
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options) { } // Corrected constructor

        public DbSet<Task> Tasks { get; set; }
        // ... other DbSets if you have them ...
    }
}