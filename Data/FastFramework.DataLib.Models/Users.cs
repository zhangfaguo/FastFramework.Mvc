using System;
using System.ComponentModel.DataAnnotations;

namespace FastFramework.DataLib.Models
{

    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string PassWord { get; set; }

        public DateTime RegistTime { get; set; }
    }
}
