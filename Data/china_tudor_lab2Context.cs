using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using china_tudor_lab2.Models;

namespace china_tudor_lab2.Data
{
    public class china_tudor_lab2Context : DbContext
    {
        public china_tudor_lab2Context (DbContextOptions<china_tudor_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<china_tudor_lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<china_tudor_lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
