using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameForumWeb.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public string GameName { get; set; }
        public string ImageUrl { get; set; }
        public string Company { get; set; }
        public string Platform { get; set; }
        public double Score { get; set; } 
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
