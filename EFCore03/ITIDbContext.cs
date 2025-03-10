using EFCore03.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFCore03
{
    internal class ITIDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = SAMER; Database = EFITI; Integrated Security = True; TrustServerCertificate = True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseInstructor>(c =>
            {
                c.HasKey(nameof(CourseInstructor.InstructorId), nameof(CourseInstructor.CourseId));
            });

            modelBuilder.Entity<StudentCourse>(s =>
            {
                s.HasKey(nameof(StudentCourse.StudentId), nameof(StudentCourse.CourseId));
            });

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<CourseInstructor> CourseInstructors { get; set; }
    }
}
 