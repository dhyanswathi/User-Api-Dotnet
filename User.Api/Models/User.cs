using System.ComponentModel.DataAnnotations;

namespace User.Api.Models
{
    public class User
    {
        [Key]
        [EmailAddress]
        public string UserLoginId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        
    }
}