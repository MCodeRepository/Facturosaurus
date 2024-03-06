using System;

namespace Facturosaurus.Api.Models
{
    public class UserNewPasswordDto
    {
        public Guid Id { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
