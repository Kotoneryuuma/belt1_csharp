using Microsoft.EntityFrameworkCore;

 
namespace belt1.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users {get;set;}
        public DbSet<DojoActivity> DojoActivitys {get;set;}
        public DbSet<Associate> Assosiates {get;set;}

    }
}