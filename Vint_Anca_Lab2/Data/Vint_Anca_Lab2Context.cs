using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vint_Anca_Lab2.Models;

namespace Vint_Anca_Lab2.Data
{
    public class Vint_Anca_Lab2Context : DbContext
    {
        public Vint_Anca_Lab2Context (DbContextOptions<Vint_Anca_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Vint_Anca_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Vint_Anca_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Vint_Anca_Lab2.Models.Author>? Authors { get; set; }

        public DbSet<Vint_Anca_Lab2.Models.Category>? Category { get; set; }
    }
}
