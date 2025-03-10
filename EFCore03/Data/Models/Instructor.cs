using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore03.Data.Models
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Bouns { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public decimal HourRate { get; set; }

        [InverseProperty(nameof(Department.Manager))]
        public Department? ManageDepartment { get; set; }

        [ForeignKey(nameof(WorksFor))]
        public int DepartmentId { get; set; }

        [InverseProperty(nameof(Department.Instructors))]
        public required Department WorksFor { get; set; }

        public ICollection<CourseInstructor> InstructorCourses { get; set; } = new HashSet<CourseInstructor>();
    }
}
