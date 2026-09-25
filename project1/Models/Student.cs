using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentSystem.Models
{
    internal class Student
    {
       public int StudentId { get; set; }
       public DateOnly? DateOfBirth { get; set; }
        [MaxLength(100)]
       public string Name { get; set; }
        [MaxLength(10)]
        [Unicode(false)]
       public string? PhoneNumber { get; set; }
        public DateTime RegisteredOn { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }
        public HomeworkSubmission HomeworkSubmission { get; set; }   
    }
}
