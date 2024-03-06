using System;

namespace Facturosaurus.Api.Models
{
    public class UserModifyDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool Active { get; set; }
        public int RoleId { get; set; }
    }
}
