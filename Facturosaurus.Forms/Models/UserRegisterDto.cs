﻿namespace Facturosaurus.Forms.dtos
{
    internal class UserRegisterDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string PhoneNumber { get; set; }
        public bool Active { get; set; }
        public int RoleId { get; set; }
    }
}