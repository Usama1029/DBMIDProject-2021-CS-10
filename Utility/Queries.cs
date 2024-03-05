using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DBLabProjectMID.Utility
{
   public class Queries
    {
        public static DataTable queryLookUpValues(string category)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Name from Lookup where Category = @category", con);
            cmd.Parameters.AddWithValue("@category", category);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public static void addstudentquery(string fname, string lname, string contact, string email, string reg, string status)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into Student values (@fname,@lname,@contact,@email,@reg,@status)", con);
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@contact", contact);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@reg", reg);
            cmd.Parameters.AddWithValue("@status", findLookUpId(status));
            cmd.ExecuteNonQuery();


        }

        public static int findLookUpId(string name)
        {
            int id;

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Lookup where Name = @status", con);
            cmd.Parameters.AddWithValue("@status", name);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            id = (int)(dt.Rows[0][0]);

            return id;
        }
        public static void queryforedit(string fname,string lname,string contact,string email,string regno,string status,string id)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UPDATE Student SET FirstName = @fname,LastName = @lname,Contact = @contact,Email = @email,RegistrationNumber = @regno,Status = @status WHERE Id = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@contact", contact);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@regno", regno);
            cmd.Parameters.AddWithValue("@status", findLookUpId(status));
            cmd.ExecuteNonQuery();

        }
        public static DataTable queryforallstudent()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT S.Id, S.FirstName, S.LastName, S.Contact, S.Email, S.RegistrationNumber, L.Name AS Status FROM Student S JOIN Lookup L ON S.Status = L.LookupId;", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable queryforactivestudent()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT S.Id, S.FirstName, S.LastName, S.Contact, S.Email, S.RegistrationNumber, L.Name AS Status FROM Student S JOIN Lookup L ON S.Status = L.LookupId WHERE L.Name = 'Active';", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public static bool regnoexist(string regno)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Student WHERE RegistrationNumber = @regNo", con);
            cmd.Parameters.AddWithValue("@regno", regno);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable atdDt = new DataTable();
            da.Fill(atdDt);

            if ((int)atdDt.Rows[0][0] == 0)
            {
                return false;
            }
            return true;
        }

       
    }
}
