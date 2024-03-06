using System;


namespace Facturosaurus.Forms.Forms.Menu
{
    public class LoggedUser
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Active { get; set; }
        public string RoleName { get; set; }
        public string Token { get; set; }
    }
}
