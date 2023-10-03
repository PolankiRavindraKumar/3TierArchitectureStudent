using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BO;
using BAL;

namespace StudentUI
{
    public partial class InsertStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DisplayStudentData();
            }
        }
        public void DisplayStudentData()
        {
            Service service = new Service();
            List<Student> student = service.GetStudents();
            gvStudent.DataSource = student;
            gvStudent.DataBind();
            Session["student"] = student;
        }

        protected void Insert_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Id = Convert.ToInt32(tbId.Text);
            student.Name = tbName.Text;
            student.Age = Convert.ToInt32(tbAge.Text);
            student.Class = tbClass.Text;
            Service service = new Service();
            service.AddStudent(student);
            DisplayStudentData();
            Response.Redirect("StudentInfo.aspx");
        }
    }
}