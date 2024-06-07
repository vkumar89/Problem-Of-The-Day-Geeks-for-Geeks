using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Portfolio.Models
{
    public class ProjectDBContext : DbContext
    {
        public ProjectDBContext():base("ConStr")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ProjectDBContext>());
        }
        public DbSet<Project> projects { get; set; }
    }
}