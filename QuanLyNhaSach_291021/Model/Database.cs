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

        public string getLastInsertedValue()
        {
            DataTable dt = loadData("SELECT SCOPE_IDENTITY() as ID");
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["ID"].ToString();
            }
            return "";
        }

        public int executeDatabase(string s)
        {
            try
            {
                SqlCommand command = con.CreateCommand();
                command.CommandText = s;
                return command.ExecuteNonQuery();
                //string ss = s.Replace("'", "");
                //insertHitory(@"Insert into History values('" + @ss + "')");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("there was an sql issue when execute Database: " + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("there was another issue when execute Database: " + ex.ToString());
            }
            return -1;
        }

        public void executeDataSet(string procName, DataTable datatable)
        {
            //sqlcon as SqlConnection  
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@insertDet", datatable);
            cmd.ExecuteReader();
        }
        public void insertHitory(string s)
        {
            try
            {
                SqlCommand command = con.CreateCommand();
                command.CommandText = s;
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("there was an sql issue when insert Hitory: " + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("there was another issue when insert Hitory: " + ex.ToString());
            }
        }
    }
}
