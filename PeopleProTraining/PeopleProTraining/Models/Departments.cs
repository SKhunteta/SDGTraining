using System;
using System.Data.Entity;

namespace PeopleProTraining.Dal.Models
{
    public class Departments
    {
        public int ID { get; set; }
        public string DepartmentsName { get; set; }

    }

    public class DepartmentsDBContext : DbContext
    {
        public DbSet<Departments> Buildings { get; set; }
    }
}