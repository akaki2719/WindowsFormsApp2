using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WindowsFormsApp2
{
    public class SQLProcedures
    {
        public static string connstr = System.Configuration.ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString;
        public static SqlConnection conn = new SqlConnection(connstr);
        public static SqlCommand cmd;
        public static SqlDataAdapter dataAdapter;
        // course
        public static void CreateCourse(string Name)
        {
            cmd = new SqlCommand("CreateCourse", conn);

            SqlParameter[] paramss = new SqlParameter[1];

            paramss[0] = new SqlParameter("@name", SqlDbType.VarChar, (100));
            paramss[0].Value = Name;

            cmd.Parameters.AddRange(paramss);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void DeleteCourse(int id)
        {
            cmd = new SqlCommand("DeleteCourse", conn);

            SqlParameter[] paramss = new SqlParameter[1];

            paramss[0] = new SqlParameter("@id", SqlDbType.Int);
            paramss[0].Value = id;

            cmd.Parameters.AddRange(paramss);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static DataTable SelectCourse()
        {
            cmd = new SqlCommand("SelectCourse", conn);
            dataAdapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            return table;
        }
        public static void UpdateCourse(int id, string name)
        {
            cmd = new SqlCommand("UpdateCourse", conn);

            SqlParameter[] paramss = new SqlParameter[2];

            paramss[0] = new SqlParameter("@id", SqlDbType.Int);
            paramss[0].Value = id;
            paramss[1] = new SqlParameter("@name", SqlDbType.VarChar, (100));
            paramss[1].Value = name;

            cmd.Parameters.AddRange(paramss);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        // grade
        public static void CreateGrade(int mark, string type)
        {
            cmd = new SqlCommand("CreateGrade", conn);

            SqlParameter[] paramss = new SqlParameter[2];
            paramss[0] = new SqlParameter("@mark", SqlDbType.Int);
            paramss[0].Value = mark;

            paramss[1] = new SqlParameter("@type", SqlDbType.VarChar, (100));
            paramss[1].Value = type;

            cmd.Parameters.AddRange(paramss);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void DeleteGrade(int id)
        {
            cmd = new SqlCommand("DeleteGrade", conn);

            SqlParameter[] paramss = new SqlParameter[1];

            paramss[0] = new SqlParameter("@id", SqlDbType.Int);
            paramss[0].Value = id;

            cmd.Parameters.AddRange(paramss);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static DataTable SelectGrade()
        {
            cmd = new SqlCommand("SelectGrade", conn);
            dataAdapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            return table;
        }
        public static void UpdateGrade(int mark, string type)
        {
            cmd = new SqlCommand("UpdateGrade", conn);

            SqlParameter[] paramss = new SqlParameter[2];

            paramss[0] = new SqlParameter("@mark", SqlDbType.Int);
            paramss[0].Value = mark;
            paramss[1] = new SqlParameter("@type", SqlDbType.VarChar, (100));
            paramss[1].Value = type;

            cmd.Parameters.AddRange(paramss);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        // HomeWork
        public static void CreateHomework(string title, string description)
        {
            cmd = new SqlCommand("CreateHomewoek", conn);

            SqlParameter[] paramss = new SqlParameter[2];
            paramss[0] = new SqlParameter("@title", SqlDbType.VarChar);
            paramss[0].Value = title;

            paramss[1] = new SqlParameter("@description", SqlDbType.Text);
            paramss[1].Value = description;

            cmd.Parameters.AddRange(paramss);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void DeleteHomework(int id)
        {
            cmd = new SqlCommand("DeleteHomework", conn);

            SqlParameter[] paramss = new SqlParameter[1];

            paramss[0] = new SqlParameter("@id", SqlDbType.Int);
            paramss[0].Value = id;

            cmd.Parameters.AddRange(paramss);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static DataTable SelectHomework()
        {
            cmd = new SqlCommand("SelectHomework", conn);
            dataAdapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            return table;
        }
        public static void UpdateHomework(string title, string description)
        {
            cmd = new SqlCommand("UpdateHomework", conn);

            SqlParameter[] paramss = new SqlParameter[2];

            paramss[0] = new SqlParameter("@title", SqlDbType.VarChar);
            paramss[0].Value = title;
            paramss[1] = new SqlParameter("@description", SqlDbType.Text);
            paramss[1].Value = description;

            cmd.Parameters.AddRange(paramss);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        // Student
        public static void CreateStudent(string name, string lastname,string username,string password)
        {
            cmd = new SqlCommand("CreateStudent", conn);

            SqlParameter[] paramss = new SqlParameter[4];
            paramss[0] = new SqlParameter("@name", SqlDbType.VarChar, (100));
            paramss[0].Value = name;

            paramss[1] = new SqlParameter("@lastname", SqlDbType.VarChar, (100));
            paramss[1].Value = lastname;

            paramss[2] = new SqlParameter("@username", SqlDbType.VarChar, (100));
            paramss[2].Value = username;

            paramss[3] = new SqlParameter("@password", SqlDbType.VarChar, (100));
            paramss[3].Value = password;

            cmd.Parameters.AddRange(paramss);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void DeleteStudent(int id)
        {
            cmd = new SqlCommand("DeleteStudent", conn);

            SqlParameter[] paramss = new SqlParameter[1];

            paramss[0] = new SqlParameter("@id", SqlDbType.Int);
            paramss[0].Value = id;

            cmd.Parameters.AddRange(paramss);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static DataTable SelectStudent()
        {
            cmd = new SqlCommand("SelectStudent", conn);
            dataAdapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            return table;
        }
        public static void UpdateStudent(string name, string lastname, string username, string password)
        {
            cmd = new SqlCommand("UpdateStudent", conn);

            SqlParameter[] paramss = new SqlParameter[4];
            paramss[0] = new SqlParameter("@name", SqlDbType.VarChar, (100));
            paramss[0].Value = name;

            paramss[1] = new SqlParameter("@lastname", SqlDbType.VarChar, (100));
            paramss[1].Value = lastname;

            paramss[2] = new SqlParameter("@username", SqlDbType.VarChar, (100));
            paramss[2].Value = username;

            paramss[3] = new SqlParameter("@password", SqlDbType.VarChar, (100));
            paramss[3].Value = password;

            cmd.Parameters.AddRange(paramss);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        // Submission
        public static void CreateSubmission(string solution, string comment)
        {
            cmd = new SqlCommand("CreateSubmission", conn);

            SqlParameter[] paramss = new SqlParameter[2];
            paramss[0] = new SqlParameter("@solution", SqlDbType.Text);
            paramss[0].Value = solution;

            paramss[1] = new SqlParameter("@comment", SqlDbType.Text);
            paramss[1].Value = comment;

            cmd.Parameters.AddRange(paramss);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void DeleteSubmission(int id)
        {
            cmd = new SqlCommand("DeleteSubmission", conn);

            SqlParameter[] paramss = new SqlParameter[1];

            paramss[0] = new SqlParameter("@id", SqlDbType.Int);
            paramss[0].Value = id;

            cmd.Parameters.AddRange(paramss);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static DataTable SelectSubmission()
        {
            cmd = new SqlCommand("SelectSubmission", conn);
            dataAdapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            return table;
        }

        public static void UpdateSubmission(string solution, string comment)
        {
            cmd = new SqlCommand("UpdateSubmission", conn);

            SqlParameter[] paramss = new SqlParameter[2];
            paramss[0] = new SqlParameter("@solution", SqlDbType.Text);
            paramss[0].Value = solution;

            paramss[1] = new SqlParameter("@comment", SqlDbType.Text);
            paramss[1].Value = comment;

            cmd.Parameters.AddRange(paramss);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        // teacher
        public static void CrateTeacher(string name, string lastname, string username, string password)
        {
            cmd = new SqlCommand("CreateTeacher", conn);

            SqlParameter[] paramss = new SqlParameter[4];
            paramss[0] = new SqlParameter("@name", SqlDbType.VarChar, (100));
            paramss[0].Value = name;

            paramss[1] = new SqlParameter("@lastname", SqlDbType.VarChar, (100));
            paramss[1].Value = lastname;

            paramss[2] = new SqlParameter("@username", SqlDbType.VarChar, (100));
            paramss[2].Value = username;

            paramss[3] = new SqlParameter("@password", SqlDbType.VarChar, (100));
            paramss[3].Value = password;

            cmd.Parameters.AddRange(paramss);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void DeleteTeacher(int id)
        {
            cmd = new SqlCommand("DeleteTeacher", conn);

            SqlParameter[] paramss = new SqlParameter[1];

            paramss[0] = new SqlParameter("@id", SqlDbType.Int);
            paramss[0].Value = id;

            cmd.Parameters.AddRange(paramss);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static DataTable SelectTeacher()
        {
            cmd = new SqlCommand("SelectTeacher", conn);
            dataAdapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            return table;
        }
        public static void UpdateTeacher(int id,string name, string lastname, string username, string password)
        {
            cmd = new SqlCommand("UpdateTeacher", conn);

            SqlParameter[] paramss = new SqlParameter[5];
            paramss[0] = new SqlParameter("@id", SqlDbType.Int);
            paramss[0].Value = id;

            paramss[1] = new SqlParameter("@name", SqlDbType.VarChar, (100));
            paramss[1].Value = name;

            paramss[2] = new SqlParameter("@lastname", SqlDbType.VarChar, (100));
            paramss[2].Value = lastname;

            paramss[3] = new SqlParameter("@username", SqlDbType.VarChar, (100));
            paramss[3].Value = username;

            paramss[4] = new SqlParameter("@password", SqlDbType.VarChar, (100));
            paramss[4].Value = password;

            cmd.Parameters.AddRange(paramss);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}