using System.ComponentModel.DataAnnotations;

namespace OnlineShopping.Models
{
    public class User
    {
        public int Id { get; set; }
        //email validation
        [DataType(DataType.EmailAddress, ErrorMessage ="Please enter valid email!!")]
        public string UserName { get; set; }
        //password .. ko form ma dekahuna ko laghi
        [DataType(DataType.Password)]
        //password validation ko laghi
        [StringLength(50,MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long.")]
        public string Password { get; set; }
        public string UserType { get; set; }

    }
}
