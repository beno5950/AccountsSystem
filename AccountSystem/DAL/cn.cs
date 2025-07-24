using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountSystem.DAL
{
    class cn
    {
        
            SqlConnection conn;
            SqlCommand cmd = new SqlCommand();


            //constractor to intailize connection
            public cn()
            {
                string Mode = Properties.Settings.Default.Mode;
                if (Mode == "Win")
                {
                    conn = new SqlConnection(@"server=" + Properties.Settings.Default.Server + ";database=" + Properties.Settings.Default.DB + ";integrated security=true;");
                }
                else
                {
                    conn = new SqlConnection(@"server=" + Properties.Settings.Default.Server + ";database=" + Properties.Settings.Default.DB + ";integrated security=false;user id =" + Properties.Settings.Default.User + ";password=" + Properties.Settings.Default.PWD + ";");
                }
            }
            //methd to open connection
            public void openConnection()
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
            }
            //method to close connection
            public void closeConnection()
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            //method to insert,update  and delete from database using stored procedure
            public void ExcuteCmd(string sp, SqlParameter[] para)
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sp;
                cmd.Connection = conn;
                if (para != null)
                {
                    cmd.Parameters.AddRange(para);
                }
                cmd.ExecuteNonQuery();
            }
            //method to read data from database using stored procedure
            public DataTable selectData(string sp, SqlParameter[] para)
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sp;
                cmd.Connection = conn;
                if (para != null)
                {
                    for (int j = 0; j < para.Length; j++)
                    {
                        cmd.Parameters.Add(para[j]);
                    }
                }
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dt.Clear();
                sda.Fill(dt);
                return dt;

            }


        //method to read data from database using stored procedure
        public DataTable selectData(string qry)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = qry;
            SqlDataAdapter sda = new SqlDataAdapter(qry,conn);
            DataTable dt = new DataTable();
            dt.Clear();
            sda.Fill(dt);
            return dt;

        }

        //method to insert ,update,delete,and other using Text
        public void ExcuteText(string txt)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = txt;
            cmd.Connection = conn;
            cmd = new SqlCommand(txt,conn);
            cmd.ExecuteNonQuery();
        }
    }
}
