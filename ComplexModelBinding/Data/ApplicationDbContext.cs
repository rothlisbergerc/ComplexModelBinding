using ComplexModelBinding.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexModelBinding.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // add instructor to the database
        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<Course> Courses { get; set; }
    }
}
