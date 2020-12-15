using System;

namespace WebApi.Dtos
{
    public class LoginDto
    {
        public int UserId { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime? LogoutTime { get; set; }
        public string ClientIPAddress { get; set; }
    }
}
