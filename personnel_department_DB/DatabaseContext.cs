using Microsoft.EntityFrameworkCore;
using personnel_department_DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personnel_department_DB
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Position> Positions { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options) 
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var posDirectorId= Guid.NewGuid();
            var posAccountantId=Guid.NewGuid();
            modelBuilder.Entity<Position>().
                HasData(
                new Position { Id = posDirectorId, Name = "Директор"},
                new Position {Id=posAccountantId,Name="Бухгалтер"});
        }
    }
}
