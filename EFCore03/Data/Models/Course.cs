using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore03.Data.Models
{
    internal class Course
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required int Duration { get; set; }


        [ForeignKey(nameof(Topic))]
        public int? TopicId { get; set; }


        [InverseProperty(nameof(Topic.Courses))]
        public Topic Topic { get; set; }


        public ICollection<StudentCourse> CourseStudents { get; set; } = new HashSet<StudentCourse>();


        public ICollection<CourseInstructor> CourseInstructors { get; set; } = new HashSet<CourseInstructor>();

    }
}
 