using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    internal class Dao
    {
        
        public SqlConnection connection() {
            string str = "Data Source=Adam\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True;Encrypt=False";
            SqlConnection sc =new SqlConnection(str);
            sc.Open();
            return sc;
        }
        public SqlCommand command(string sql) {
            SqlCommand sc = new SqlCommand(sql, connection());
            return  sc;
        }
        public int Excute(string sql) { 
            return command(sql).ExecuteNonQuery();
        }

        public SqlDataReader read(string sql) {
            return command(sql).ExecuteReader();
        }

    }
}
