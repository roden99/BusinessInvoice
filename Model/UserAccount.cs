using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserAccount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public string AccessType { get; set; }
        public bool IsActive { get; set; }
        public string EmailAddress { get; set; }
        public string VerifyCode { get; set; }
        public bool IsVerified { get; set; }
    }
}
