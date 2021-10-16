using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vehicle_Insurance_Management_System.Models;
using System.Data.Entity;

namespace Vehicle_Insurance_Management_System.DataContext
{
    public class Vehicle_InsuranceDbContext:DbContext
    {
        public DbSet<Customers> Customers { get; set; }
    }
}