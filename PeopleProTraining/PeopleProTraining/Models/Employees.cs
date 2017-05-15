using System;
using System.Data.Entity;

namespace PeopleProTraining.Dal.Models
{
    public class Employees
    {
        public int ID { get; set; }
        public string EmployeesName { get; set; }

    }

    public class EmployeesDBContext : DbContext
    {
        public DbSet<Employees> Employees { get; set; }
    }
}