using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Muresan_Bogdan_lab2.Models;

namespace Muresan_Bogdan_lab2.Data
{
    public class Muresan_Bogdan_lab2Context : DbContext
    {
        public Muresan_Bogdan_lab2Context (DbContextOptions<Muresan_Bogdan_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Muresan_Bogdan_lab2.Models.Book> Book { get; set; } = default!;
    }
}
