using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentSystem.Models
{
    internal class Course
    {
        public int CourseId { get; set; }
        [Unicode(true)]
        public string? Description { get; set; }

        public DateOnly EndDate { get; set; }
        [MaxLength(80)]
        [Unicode(true)]

        public string Name { get; set; }

        public decimal Price { get; set; }
        public DateOnly StartDate { get; set; }

        public ICollection<Resource> Resources { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }

        public ICollection<HomeworkSubmission> HomeworkSubmissions { get; set; }
    }
}
