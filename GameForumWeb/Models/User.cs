using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameForumWeb.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public virtual ICollection<Bookmark> Bookmarks { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }

}