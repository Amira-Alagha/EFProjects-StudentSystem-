using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Security.AccessControl;
namespace StudentSystem.Models
{
    internal class Resource
    {
        public int ResourceId { get; set; }
        [MaxLength(50)]
        [Unicode(true)]
        public string Name { get; set; }
        [Unicode(false)]
        public string Url { get; set; }
        public ResourceType ResourceType { get; set; }

        public int CourseId { get; set; }

        public Course Course { get; set; }
    }
}
