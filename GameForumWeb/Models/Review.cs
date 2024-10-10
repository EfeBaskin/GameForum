using System.ComponentModel.DataAnnotations;

namespace GameForumWeb.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        public int GameId { get; set; }
        public int UserId { get; set; } 
        public string ReviewContent { get; set; }

        public virtual User User { get; set; }
        public virtual Game Game { get; set; }
    }

}
