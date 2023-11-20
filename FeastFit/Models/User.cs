using System.ComponentModel.DataAnnotations;
using System.Data;

namespace FitFeast.Models
{
    public class User
    {
        public User() { DateJoined = DateTime.Now; }
        public long Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public char Gender { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public string Email { get; set; }
       
        public int Weight { get; set; }
        public int Height { get; set; }
        public DateTime DateJoined { get; set; }

    }
}
