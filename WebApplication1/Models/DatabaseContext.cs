using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<FriendWith> FreindsWith { get; set; }
        public DbSet<Comments> Commentss { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Reaction>Reactions { get; set; }
        public DbSet<ReactionType> ReactionTypes { get; set; }
        public DbSet<PostImages> PostImagess { get; set; }
        public DbSet<PostVideos> PostVideoss { get; set; }
        public DbSet<DirectMessage> DirectMessages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=shpendemustafa;Database=WebApplication1;Trusted_Connection=True;");
        }
    }
}
