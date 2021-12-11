using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class RegisterData
    {
        public string FullName { get; set; }
        public DateTime DoB { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int UserID { get; set; }
        public string Email { get; set; }
    }
}
