using System.ComponentModel.DataAnnotations;

namespace Logicathon.Models.DTO
{
    public class User
    {
        [Key]
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Department { get; set; }
    }
}
