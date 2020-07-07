using Microsoft.EntityFrameworkCore;
using System;

namespace MriduBooks.Models
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
