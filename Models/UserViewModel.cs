
using System.ComponentModel.DataAnnotations;

namespace OnlineShopping.Models
{
    public class UserViewModel
    {
        //validate the email
        [DataType(DataType.EmailAddress, ErrorMessage = "Please enter a valid email!")]
        public string UserName { get; set; }
        //hide the password in the form
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters long.")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Enter the same password")]
        public string ConfirmPassword { get; set; }
    }
}
