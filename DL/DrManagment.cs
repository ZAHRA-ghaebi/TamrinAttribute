using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DL
{
    public class DrManagment
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=doctormanagment;Integrated Security=True;");

        public SqlCommand GetCom(string con)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            return cmd;
        }
        public List<Doctor> Select()
        {
            var command = GetCom("[dbo].[selectDr]");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            conn.Close();
            var list = new List<Doctor>(dt.Rows.Count);
            foreach (DataRow row in dt.Rows)
            {
                var dr = new Doctor
                {
                    FirstName = row["FirstName"].ToString(),
                    LastName = row["LastName"].ToString(),
                    PhoneNumber = row["PhoneNumber"].ToString(),
                    Id = (int)row["Id"]
                };
                list.Add(dr);
            }
            return list;
        }
        public void Insert(Doctor doctor)
        {
            var command = GetCom("[dbo].[insertDr]");
            command.Parameters.AddWithValue("@FirstName", doctor.FirstName);
            command.Parameters.AddWithValue("@LastName", doctor.LastName);
            command.Parameters.AddWithValue("PhoneNumber", doctor.PhoneNumber);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
    }

}
