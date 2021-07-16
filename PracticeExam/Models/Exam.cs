using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeExam.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public string StartTime { get; set; }
        public string ExamDate { get; set; }
        public int ExamDuration { get; set; }

        public int ClassRoomId { get; set; }
        public int FacultyId { get; set; }
        public string Status { get; set; }

        public virtual ClassRoom ClassRoom { get; set; }
        public virtual Faculty Faculty { get; set; }
        public virtual Subject Subject { get; set; }
    }
}