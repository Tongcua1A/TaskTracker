using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace TaskTracker.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public DateTime DueDate { get; set; }

        public string Priority { get; set; }

        public string Status { get; set; }

        [BindNever] // <-- IMPORTANT: prevent this from needing to be in the form
        public string UserId { get; set; } = "";
    };
}
