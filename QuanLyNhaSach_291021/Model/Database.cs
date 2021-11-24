using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyNhaSach_291021.Model
{
    class Database
    {
        string server = @"MOU\SQLEXPRESS";
        string databasename = "QuanLyNhaSach";
        SqlConnection con;

        public Database()
        {
            string conStringLocal = @"Data Source=" + server + ";Initial Catalog=" + databasename + ";Integrated Security=True";
            con = new SqlConnection(conStringLocal);
            con.Open();

        }

        public DataTable loadData(string s)
        {
            SqlCommand cmdSelect = new SqlCommand(@s, con);
            SqlDataAdapter daSelect = new SqlDataAdapter(cmdSelect);
            DataTable tableSelect = new DataTable("mytable");
            daSelect.Fill(tableSelect);
            return tableSelect;
        }

        public int executeDatabase(string s)
        {
            SqlCommand command = con.CreateCommand();
            command.CommandText = s;
            return command.ExecuteNonQuery();
            //string ss = s.Replace("'", "");
            //insertHitory(@"Insert into History values('" + @ss + "')");
        }

        public void insertHitory(string s)
        {
            SqlCommand command = con.CreateCommand();
            command.CommandText = s;
            command.ExecuteNonQuery();
        }
    }
}
