using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class AdminData
    {
        public string FullName { get; set; }       
        public int AdminID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
