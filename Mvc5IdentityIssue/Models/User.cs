using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc5IdentityIssue.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Username required", AllowEmptyStrings = false)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password required", AllowEmptyStrings = false)]
        public string Password { get; set; }

        public string FullName { get; set; }

        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Email is not valid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Gender required", AllowEmptyStrings = false)]
        public string Gender { get; set; }
    }
}