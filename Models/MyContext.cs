
using Microsoft.EntityFrameworkCore;
#pragma warning disable CS8618
namespace BiblioApp.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) {}

        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Banned> Banneds { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Borrow> Borrows { get; set; }
        public DbSet<Collection> Collections { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Exchange> Exchanges { get; set; }
        public DbSet<UserBook> UserBooks { get; set; }
        public DbSet<Like> Likes { get; set; }
    }
}

 