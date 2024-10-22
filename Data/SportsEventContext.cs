using _22._10._24_Practice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._10._24_Practice.Data
{
    public class SportsEventContext : DbContext
    {
        public DbSet<SportEvent> SportEvents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("SportsEventsDB");
        }
    }
}
