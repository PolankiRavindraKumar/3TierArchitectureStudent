using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using BO;
namespace StudentUI
{
    public partial class StudentInfo : System.Web.UI.Page
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

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertStudent.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateStudent.aspx");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchStudent.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteStudent.aspx");
        }
    }
}