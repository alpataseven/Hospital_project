using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hospital_project
{
    internal class sqlConnect
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=Alp\\SQLEXPRESS;Initial Catalog=Hospital_project;Integrated Security=True;Trust Server Certificate=True"); 
            baglan.Open();
            return baglan;
        }
    }
}
