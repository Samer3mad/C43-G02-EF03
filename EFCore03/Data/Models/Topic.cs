using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore03.Data.Models
{
    internal class Topic
    {
        public required int Id { get; set; }
        public required string Name { get; set; }


        [InverseProperty(nameof(Course.Topic))]
        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
