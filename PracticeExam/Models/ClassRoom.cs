using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PracticeExam.Models
{
    public class ClassRoom
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }
        
        public virtual ICollection<Exam> Exams { get; set; }
    }
}