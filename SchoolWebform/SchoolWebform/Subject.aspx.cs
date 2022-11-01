using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolWebform
{
    public partial class Subject : System.Web.UI.Page
    {
        string connection = @"Data Source=mysqlbarani.database.windows.net;Initial Catalog=school;User ID=barani;Password=admin@123";
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection s = new SqlConnection(connection))
            {
                s.Open();
                SqlDataAdapter sd = new SqlDataAdapter("select * from Subjects", connection);
                DataTable dtable = new DataTable();
                sd.Fill(dtable);
                Subjects.DataSource = dtable;
                Subjects.DataBind();
            }

        }

        protected void BackButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SchoolDetails.aspx");
        }

        protected void Subjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}