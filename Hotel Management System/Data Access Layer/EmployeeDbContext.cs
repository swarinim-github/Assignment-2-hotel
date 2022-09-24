﻿using Hotel_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Management_System.Data_Access_Layer
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> employees { get; set; } 
    }
}
