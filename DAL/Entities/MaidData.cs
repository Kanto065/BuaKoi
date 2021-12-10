using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class MaidData
    {
        public string FullName { get; set; }
        public DateTime DoB { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string WorkAddress { get; set; }
        public int MaidID { get; set; }
        public string WorkTime { get; set; }
        public string WorkExperience { get; set; }
        public string ExpectedSalary { get; set; }
    }
}
