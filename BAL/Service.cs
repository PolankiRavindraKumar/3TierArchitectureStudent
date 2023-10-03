using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAL;

namespace BAL
{
    public class Service
    {
        Represent re = new Represent();
        public List<Student> GetStudents()
        {
            List<Student> students = re.GetAllStudents();
            return students;
        }
        public void AddStudent(Student student)
        {
            re.InsertStudent(student);
        }
        public void UpdateStudent(Student student)
        {
            re.UpdateStudent(student);
        }
        public void DeleteStudent(Student student)
        {
            re.DeleteStudent(student);
        }
    }
}
