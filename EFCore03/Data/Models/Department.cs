using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore03.Data.Models
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime HiringDate { get; set; }

        [ForeignKey(nameof(Manager))]
        public int? ManagerId { get; set; }

        [InverseProperty(nameof(Instructor.ManageDepartment))]
        public Instructor? Manager { get; set; }

        [InverseProperty(nameof(Instructor.WorksFor))]
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();

        [InverseProperty(nameof(Student.Department))]
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
    }
}
