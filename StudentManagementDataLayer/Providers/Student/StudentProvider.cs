using StudentManagementDataLayer.Models.Student;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementDataLayer.Providers.Student
{
   public class StudentProvider
    {
        private readonly string ConString; 
       public StudentProvider(string conStr)
        {
            ConString = conStr;
        
        }
        public IEnumerable<StudentModel> GetStudents()
        {
            List<StudentModel> students = new List<StudentModel>();
            SqlConnection con = null; 
            try
            {
               con= new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Sel_Student",con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        StudentModel student = new StudentModel();
                        student.Id = Convert.ToInt32(dr["Id"]);
                        student.Name = dr["Name"].ToString();
                        student.EmailId = dr["EmailId"].ToString();
                        student.Password = dr["Password"].ToString();
                        students.Add(student);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                    
                }
                con = null;
            }

            return students;
        }

    }
}
