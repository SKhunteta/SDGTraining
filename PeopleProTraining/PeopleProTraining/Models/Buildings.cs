using System;
using System.Data.Entity;

namespace PeopleProTraining.Dal.Models
{
    public class Buildings
    {
        public int ID { get; set; }
        public string BuildingName { get; set; }
 
    }

    public class BuildingsDBContext : DbContext
    {
        public DbSet<Buildings> Buildings { get; set; }
    }
}