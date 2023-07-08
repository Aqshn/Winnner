using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using qaa;

public class WorkerContext : DbContext
{
    public DbSet<Worker> Workers { get; set; }
    public DbSet<Orderer> Orderers { get; set; }
    public DbSet<Category> Categories { get; set; }

    public WorkerContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=WorkerUI;Integrated Security=True;");
    }
}