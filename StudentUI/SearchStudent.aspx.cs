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
    public partial class SearchStudent : System.Web.UI.Page
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
        protected void Search_Click(object sender, EventArgs e)
        {
            List<Student> student = Session["student"] as List<Student>;
            foreach(Student stud in student)
            {
                if(stud.Id == Convert.ToInt32(tbId.Text))
                {
                    tbName.Text = stud.Name;
                    tbAge.Text = stud.Age.ToString();
                    tbClass.Text = stud.Class;
                    break;
                }
            }
            
        }
    }
}