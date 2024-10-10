using GameForumWeb.Models;
using System.Data.Entity;

namespace GameForumWeb.Data
{
    public class GameContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Bookmark> Bookmarks { get; set; }
        public GameContext() : base("GameContext") { }  //for app configuration options method
    }
}