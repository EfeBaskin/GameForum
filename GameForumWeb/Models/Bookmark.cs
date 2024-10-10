using System;
using System.ComponentModel.DataAnnotations;

namespace GameForumWeb.Models
{
    public class Bookmark
    {
        [Key]
        public int Id { get; set; }
        public DateTime BookmarkedAt { get; set; }

        public int GameId { get; set; }
        public virtual Game Game { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}