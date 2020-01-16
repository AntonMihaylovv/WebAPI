using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi3.Models
{   
        public class EmployeeContext : DbContext
        {
            public EmployeeContext(DbContextOptions options)
                : base(options)
            {
            }

            public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                FirstName = "Ivan",
                LastName = "Ivanonv",
                Email = "ivan.ivanonv@gmail.com",
                DateOfBirth = new DateTime(1979, 04, 25),
                PhoneNumber = "999-888-7777"

            }, new Employee
            {
                EmployeeId = 2,
                FirstName = "Pesho",
                LastName = "Peshev",
                Email = "pesho.p@gmail.com",
                DateOfBirth = new DateTime(1981, 07, 13),
                PhoneNumber = "111-222-3333"
            });
        }
    }
    
}
