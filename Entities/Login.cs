using System;

namespace WebApi.Entities
{
    public class Login
    {
        public int Id { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime? LogoutTime { get; set; }
        public string ClientIPAddress { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
