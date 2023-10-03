using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;


namespace DAL
{
    public class Represent
    {
        List<Student> students = new List<Student>();
        public List<Student> GetAllStudents()
        {
            using(SqlConnection cn = new SqlConnection(Utility.GetConnection()))
            {
                using(SqlCommand cmd = new SqlCommand("GetAllStudents", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        cn.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            Student student = new Student();
                            student.Id = Convert.ToInt32(sdr["Id"]);
                            student.Name = sdr["Student_Name"].ToString();
                            student.Age = Convert.ToInt32(sdr["Age"]);
                            student.Class = sdr["Class"].ToString();
                            students.Add(student);
                        }
                        sdr.Close();
                    }
                    catch(SqlException ex) { Console.WriteLine(ex.Message); }
                    finally
                    {
                        if (cn.State == ConnectionState.Open)
                            cn.Close();
                    }
                }
            }
            return students;
        }
        public void InsertStudent(Student student)
        {
            using(SqlConnection cn  = new SqlConnection(Utility.GetConnection()))
            {
                using(SqlCommand cmd = new SqlCommand("InsertStudent", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter Id_Parameter = new SqlParameter("@id", SqlDbType.Int);
                    SqlParameter Name_Parameter = new SqlParameter("@name", SqlDbType.VarChar,50);
                    SqlParameter Age_Parameter = new SqlParameter("@age", SqlDbType.Int);
                    SqlParameter Class_Parameter = new SqlParameter("@class", SqlDbType.VarChar, 50);
                    Id_Parameter.Value = student.Id;
                    Name_Parameter.Value = student.Name;
                    Age_Parameter.Value = student.Age;
                    Class_Parameter.Value = student.Class;
                    cmd.Parameters.Add(Id_Parameter);
                    cmd.Parameters.Add(Name_Parameter);
                    cmd.Parameters.Add(Age_Parameter);
                    cmd.Parameters.Add(Class_Parameter);
                    try
                    {
                        cn.Open();
                        int count = cmd.ExecuteNonQuery();
                    }
                    catch(SqlException ex) { Console.WriteLine(ex.Message); }
                    finally
                    {
                        if(cn.State == ConnectionState.Open)
                        {
                            cn.Close();
                        }
                    }
                }
            }
        }
        public void UpdateStudent(Student student)
        {
            using(SqlConnection cn = new SqlConnection(Utility.GetConnection()))
            {
                using(SqlCommand cmd = new SqlCommand("UpdateStudent", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter Id_Parameter = new SqlParameter("@id", SqlDbType.Int);
                    SqlParameter Name_Parameter = new SqlParameter("@name", SqlDbType.VarChar, 50);
                    SqlParameter Age_Parameter = new SqlParameter("@age", SqlDbType.Int);
                    SqlParameter Class_Parameter = new SqlParameter("@class", SqlDbType.VarChar, 50);
                    Id_Parameter.Value = student.Id;
                    Name_Parameter.Value = student.Name;
                    Age_Parameter.Value = student.Age;
                    Class_Parameter.Value = student.Class;
                    cmd.Parameters.Add(Id_Parameter);
                    cmd.Parameters.Add(Name_Parameter);
                    cmd.Parameters.Add(Age_Parameter);
                    cmd.Parameters.Add(Class_Parameter);
                    try
                    {
                        cn.Open();
                        int count = cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex) { Console.WriteLine(ex.Message); }
                    finally
                    {
                        if (cn.State == ConnectionState.Open)
                            cn.Close();
                    }
                }
            }
        }
        public void DeleteStudent(Student student)
        {
            using(SqlConnection cn = new SqlConnection(Utility.GetConnection()))
            {
                using(SqlCommand cmd = new SqlCommand("DeleteStudent", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter Id_Parameter = new SqlParameter("@id", SqlDbType.Int);
                    Id_Parameter.Value = student.Id;
                    cmd.Parameters.Add(Id_Parameter);
                    try
                    {
                        cn.Open();
                        int count = cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex) { Console.WriteLine(ex.Message); }
                    finally
                    {
                        if (cn.State == ConnectionState.Open)
                            cn.Close();
                    }
                }
            }
        }
    }
}
