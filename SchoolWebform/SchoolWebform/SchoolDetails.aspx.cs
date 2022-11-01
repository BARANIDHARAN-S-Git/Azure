using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolWebform
{
    public partial class Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void StudentButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Student.aspx");
        }

        protected void SubjectButton_Click(object sender, EventArgs e)
        { 
            Response.Redirect("~/Subject.aspx");
        }

        protected void ClassButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Class.aspx");
        }

        
    }
}