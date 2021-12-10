using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Tables;

namespace DAL
{
    public class Database
    {
        public RegisterDatatable userinfo { get; set; }

        public Database()
        {
            userinfo = new RegisterDatatable();
            //dataGridView1.DataSource = new Database().InfoTable.Get();
            
        }
    }
}
