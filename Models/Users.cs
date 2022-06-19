using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRS_Project.Models
{
    [Index(nameof(Username), IsUnique = true)]
    //[Index(nameof(Id), IsUnique = true)]
    public class User
    {
        public User()
        { }

        [Key]

        public int Id { get; set; }

        [StringLength(30)]

        public string Username { get; set; }
        [StringLength(30)]
        public string Firstname { get; set; }
        [StringLength(30)]
        public string Lastname { get; set; }
        [StringLength(30)]
        public string Password { get; set; }
        [StringLength(12)]
        public string? Phone { get; set; }
        [StringLength(225)]
        public string? Email { get; set; }

        public bool IsReviewer { get; set; }
        public bool IsAdmin { get; set; }



        //[ForeignKey("Users")]
        //private Requests UserID { get; set; }

        //public string LogIn()
        //{
        //    string ulog = Username + Password;
        //    return ulog;
        //}
    }
}
