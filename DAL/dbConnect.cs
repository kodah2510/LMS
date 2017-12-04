using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class dbConnect
    {
        string connectionString = @"Data Source=KHOA-PC\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True";
        private SqlConnection connection;

        public dbConnect()
        {
            connection = new SqlConnection(connectionString);
        }

        public DataTable GetData(string strSql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strSql, connection);
            connection.Open();
            da.Fill(dt);
            connection.Close();
            return dt;
        }

        public DataTable GetData(string procName, SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = procName;
            cmd.CommandType = CommandType.StoredProcedure;
            if(parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            cmd.Connection = connection;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            connection.Open();
            da.Fill(dt);
            connection.Close();
            return dt;
        } 
        public int ExecuteSql(string strSql)
        {
            int row = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(strSql, connection);
                connection.Open();
                row = cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException ex)
            {
                DisplaySqlErrors(ex);
            }
            return row;

        }
        public int ExecuteSql(string procName, SqlParameter[] parameters)
        {
            int row = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(procName, connection);
                cmd.CommandText = procName;
                cmd.CommandType = CommandType.StoredProcedure;
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                connection.Open();
                row = cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException ex)
            {
                DisplaySqlErrors(ex);
            }
            return row;
        }
        private void DisplaySqlErrors(SqlException exception)
        {
            string errorMessage = "";
            for (int i = 0; i < exception.Errors.Count; i++)
            {
                errorMessage = "Index #" + i + "\n" + "Error: " + exception.Errors[i].ToString() + "\n";
            }
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
