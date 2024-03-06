using System;

namespace Facturosaurus.Forms.dtos
{
    internal class UserNewPasswordDto
    {
        public Guid Id { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
