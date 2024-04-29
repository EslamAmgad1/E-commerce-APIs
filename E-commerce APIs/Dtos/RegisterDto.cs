using System.ComponentModel.DataAnnotations;

namespace E_commerce_APIs.Dtos
{
    public class RegisterDto
    {
        public string DisplayName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
