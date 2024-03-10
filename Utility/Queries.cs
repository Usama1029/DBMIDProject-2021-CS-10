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
        public static DataTable queryfordate()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("select AttendanceDate from ClassAttendance",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static int queryStudentAttendanceCountByStatus(int status, DateTime dateTime)
        {
            var con = Configuration.getInstance().getConnection();
            string query = "SELECT COUNT(*) FROM StudentAttendance S JOIN ClassAttendance C ON S.AttendanceId=C.Id WHERE AttendanceStatus = @id AND YEAR(AttendanceDate) = @year AND MONTH(AttendanceDate) = @month AND DAY(AttendanceDate) = @date";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", status);
            cmd.Parameters.AddWithValue("@year", dateTime.Year);
            cmd.Parameters.AddWithValue("@month", dateTime.Month);
            cmd.Parameters.AddWithValue("@date", dateTime.Day);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return (int)(dt.Rows[0][0]);
        }
        public static int totalclo()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("select count(*) from Clo", con);
            SqlDataAdapter count = new SqlDataAdapter(cmd);
           
            DataTable dt = new DataTable();
            count.Fill(dt);
            return (int)(dt.Rows[0][0]);
        }
        public static void queryUpadateCLO(int id, string name)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UPDATE Clo SET Name = @name,  DateUpdated = @dateTime WHERE Id = @id", con);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@dateTime", DateTime.Now);
           
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
        public static DataTable queryActiveStudentsForAttendance()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Id, CONCAT(FirstName, ' ', LastName) AS Name, RegistrationNumber FROM Student", con);
          //  cmd.Parameters.AddWithValue("@status", status);
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
        public static int querygetattendanceid(DateTime dt)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("select Id from ClassAttendance where Year(AttendanceDate) = @year and Month(AttendanceDate) = @month and Day(AttendanceDate) = @date", con);
            cmd.Parameters.AddWithValue("@year", dt.Year);
            cmd.Parameters.AddWithValue("@month", dt.Month);
            cmd.Parameters.AddWithValue("@date", dt.Day);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt2 = new DataTable();
            da.Fill(dt2);

            return (int)(dt2.Rows[0][0]);
        }
        public static void deleteattendance(int id)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Delete from StudentAttendance where AttendanceId = @ID",con);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.ExecuteNonQuery();
        }
        public static void deletedate(int id)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM ClassAttendance WHERE Id = @ID", con);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.ExecuteNonQuery();
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
        public static DataTable queryforgetclo()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("select * from Clo", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
      
        public static void insertclo(DateTime created, string name)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into Clo values (@name, @dateTime, @dateTime)", con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@dateTime", created);
            cmd.ExecuteNonQuery();

        }
        public static void insertrubric(int cloId,string details)
        {
            int id = queryGetNextRubricID();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into Rubric values (@id, @details, @cloId)", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@details", details);
            cmd.Parameters.AddWithValue("@cloId", cloId);
            cmd.ExecuteNonQuery();
        }
        public static bool isStdExistInResultAndAtd(int ID)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM StudentAttendance WHERE StudentId = @ID", con);
            cmd.Parameters.AddWithValue("@ID", ID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable atdDt = new DataTable();
            da.Fill(atdDt);

            cmd = new SqlCommand("SELECT COUNT(*) FROM StudentResult WHERE StudentId = @ID", con);
            cmd.Parameters.AddWithValue("@ID", ID);
            da = new SqlDataAdapter(cmd);
            DataTable resultDt = new DataTable();
            da.Fill(resultDt);

            if ((int)atdDt.Rows[0][0] == 0 && (int)resultDt.Rows[0][0] == 0)
            {
                return true;
            }
            return false;
        }
        public static string queryGetStatusName(int id)
        {
            var con = Configuration.getInstance().getConnection();
            string query = "SELECT Name FROM Lookup WHERE LookupId = @ID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt.Rows[0][0].ToString();
        }
        public static int queryGetAttendanceID(DateTime dateTime)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Id FROM ClassAttendance WHERE YEAR(AttendanceDate) = @year AND MONTH(AttendanceDate) = @month AND DAY(AttendanceDate) = @day", con);
            cmd.Parameters.AddWithValue("@year", dateTime.Year);
            cmd.Parameters.AddWithValue("@month", dateTime.Month);
            cmd.Parameters.AddWithValue("@day", dateTime.Day);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return (int)(dt.Rows[0][0]);
        }
        public static void queryDeletePrevAttd(int id)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM StudentAttendance WHERE AttendanceId = @ID", con);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.ExecuteNonQuery();
        }
        public static DataTable queryActiveStudentsForAttendance(string status)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Id, CONCAT(FirstName, ' ', LastName) AS Name, RegistrationNumber FROM Student WHERE Status =  (SELECT LookUpId FROM Lookup WHERE Name = @status)", con);
            cmd.Parameters.AddWithValue("@status", status);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public static void queryMarkAttendance(int id, int stID, int status)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into StudentAttendance values (@id, @stID, @status)", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@stID", stID);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.ExecuteNonQuery();
        }
        public static bool queryAddAttendanceDate(DateTime dateTime)
        {
            if (queryAttendanceDateExist(dateTime) == 0)
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Insert into ClassAttendance values (@dateTime)", con);
                cmd.Parameters.AddWithValue("@dateTime", dateTime);
                cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        public static int queryAttendanceDateExist(DateTime dateTime)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Count(*) FROM ClassAttendance WHERE YEAR(AttendanceDate) = @year AND MONTH(AttendanceDate) = @month AND DAY(AttendanceDate) = @day", con);
            cmd.Parameters.AddWithValue("@year", dateTime.Year);
            cmd.Parameters.AddWithValue("@month", dateTime.Month);
            cmd.Parameters.AddWithValue("@day", dateTime.Day);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return (int)(dt.Rows[0][0]);
        }
        public static void deletestudent(string id)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Delete  from Student where id = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
        public static DataTable queryGetStddIdsStatus(int id)
        {
            var con = Configuration.getInstance().getConnection();
            string query = "SELECT StudentId, AttendanceStatus FROM StudentAttendance WHERE AttendanceId = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static int queryGetAttdId(DateTime dateTime)
        {
            var con = Configuration.getInstance().getConnection();
            string query = "SELECT Id FROM ClassAttendance WHERE YEAR(AttendanceDate) = @year AND MONTH(AttendanceDate) = @month AND DAY(AttendanceDate) = @date";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@year", dateTime.Year);
            cmd.Parameters.AddWithValue("@month", dateTime.Month);
            cmd.Parameters.AddWithValue("@date", dateTime.Day);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return (int)(dt.Rows[0][0]);
        }

        public static DataTable queryforgetrubric()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("select * from Rubric", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static int queryGetNextRubricID()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT MAX(ID) FROM Rubric", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int id = (int)(dt.Rows[0][0]);
            id++;
            return id;
        }


    }
}
