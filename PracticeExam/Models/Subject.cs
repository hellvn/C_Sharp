using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace PracticeExam.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Enter name of subject.")]
        public string Name { get; set; }

        public virtual ICollection<Exam> Exams { get; set; }
    }
}