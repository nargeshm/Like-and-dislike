using Microsoft.EntityFrameworkCore;
using System;

namespace Demo_Dall7
{
    public class BookLibaryContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Integrated Security=True;Initial Catalog=BookLibary;Data Source=NARGES");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<BooksLike> likes { get; set; }
    }
}
