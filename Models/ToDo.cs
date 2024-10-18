using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ToDoDemo.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="please enter a description.")]
        public string Description { get; set; } = String.Empty;

        [Required(ErrorMessage = "please enter a due date.")]
        public DateTime? DueDate { get; set; }

        [Required(ErrorMessage = "please select a category.")]
        public string CategoryID { get; set; } = String.Empty;

        [ValidateNever]
        public Category Category { get; set; } = null!;

        [Required(ErrorMessage = "please select a status.")]
        public string StatusID { get; set; } = String.Empty;

        [ValidateNever]
        public Status Status { get; set; } = null!;

        public bool OverDue => StatusID == "open" && DueDate < DateTime.Today;

    }
}
