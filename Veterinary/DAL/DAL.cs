using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary.DAL
{
    class DAL
    {
        SqlConnection sqlcon;
        public DAL()
        {
            string serverName = Environment.MachineName;
            string databaseName = "Veterinary";
            string connectionString = $"Data Source={serverName}; Initial Catalog={databaseName}; Integrated Security=True";

            sqlcon = new SqlConnection(connectionString);
        }

        public void open()
        {
            if (sqlcon.State != ConnectionState.Open)
            {
                sqlcon.Open();
            }
        }
        public void close()
        {
            if (sqlcon.State == ConnectionState.Open)
            {
                sqlcon.Close();
            }
        }
        public DataTable read_data(string ps_name, SqlParameter[] ps_param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = ps_name;
            if (ps_param != null)
            {
                for (int i = 0; i < ps_param.Length; i++)
                {
                    sqlcmd.Parameters.Add(ps_param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable read_data1(string ps_name)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = ps_name;
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void execop(string ps_name, SqlParameter[] ps_param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = ps_name;
            if (ps_param != null)
            {
                for (int i = 0; i < ps_param.Length; i++)
                {
                    sqlcmd.Parameters.Add(ps_param[i]);
                }
            }
            sqlcmd.ExecuteNonQuery();
        }
    }
}
