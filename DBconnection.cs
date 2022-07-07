using System;
using System.Data;
using System.Data.SqlClient;
namespace Akis3
{
   class SqlConnect
    {
        public SqlConnection con;
        public void connection()
        {
            con = new SqlConnection("Data Source=LAPTOP-NCDFA6OH\\SQLEXPRESS;Initial Catalog=202325011;Integrated Security=True");
        }
    }
}
