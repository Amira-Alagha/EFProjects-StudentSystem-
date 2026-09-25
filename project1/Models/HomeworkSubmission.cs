using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Text;

namespace StudentSystem.Models
{
    internal class HomeworkSubmission
    {

        public int Id { get; set; }
        [Unicode(false)]
        public string Content { get; set; }
        public ContentTypes ContentType { get; set; }
        public DateOnly SubmissionTime { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
