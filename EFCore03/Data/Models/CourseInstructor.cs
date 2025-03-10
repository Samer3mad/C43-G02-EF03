using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore03.Data.Models
{
    //[PrimaryKey(nameof(InstructorId), nameof(CourseId))]
    internal class CourseInstructor
    {
        public int InstructorId { get; set; }
        public int CourseId { get; set; }
        public string Evaluation  { get; set; }
    }
}
