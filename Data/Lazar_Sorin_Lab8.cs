using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lazar_Sorin_Lab8.Models;

namespace Lazar_Sorin_Lab8.Data
{
    public class Lazar_Sorin_Lab8Context : DbContext
    {
        public Lazar_Sorin_Lab8Context (DbContextOptions<Lazar_Sorin_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Lazar_Sorin_Lab8.Models.Book> Book { get; set; }

        public DbSet<Lazar_Sorin_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Lazar_Sorin_Lab8.Models.Category> Category { get; set; }
    }
}
