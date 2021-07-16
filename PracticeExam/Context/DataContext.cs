using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PracticeExam.Models;


namespace PracticeExam.Context
{
    public class DataContext : DbContext
    {
        public DataContext() : base("WAD_PracticeExam")
        {

        }

        public System.Data.Entity.DbSet<PracticeExam.Models.Subject> Subjects { get; set; }

        public System.Data.Entity.DbSet<PracticeExam.Models.ClassRoom> ClassRooms { get; set; }

        public System.Data.Entity.DbSet<PracticeExam.Models.Faculty> Faculties { get; set; }

        public System.Data.Entity.DbSet<PracticeExam.Models.Exam> Exams { get; set; }
    }
}