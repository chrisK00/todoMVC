using Microsoft.EntityFrameworkCore;
using System;
using todoMVC.DL.Models;

namespace todoMVC.DL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; }
    }
}
