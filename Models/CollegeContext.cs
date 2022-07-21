using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.net_student.Models
{
    public class CollegeContext : DbContext
    {
       

        public CollegeContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Department>().HasData(new Department()
            {
                Id = 101,
                Name = "Admin"
            });

            modelBuilder.Entity<Department>().HasData(new Department()
            {
                Id = 102,
                Name = "Developer"
            });
            modelBuilder.Entity<Student>().HasData(new Student()
            {
                Id = 1,
                Name = "Tim",
                Age = 21,
                Gender="Male",
                Email="aaa@gmail.com",
                EnrollmentDate="01-01-2022",
                Phone=9876543212,
                country="india",
                DepartmentId = 101
            });
            modelBuilder.Entity<Student>().HasData(new Student()
            {
                Id = 2,
                Name = "jim",
                Age = 22,
                Gender = "Female",
                Email = "bbb@gmail.com",
                EnrollmentDate = "02-01-2022",
                Phone = 9876543219,
                country = "india",
                DepartmentId = 101


            });
            //  protected override void OnModelCreating(ModelBuilder modelBuilder)
            //{
            //    modelBuilder.Entity<Student>().ToTable("Students");
            //    modelBuilder.Entity<Department>().ToTable("Departments");

            //}
        }
    }
}


    


