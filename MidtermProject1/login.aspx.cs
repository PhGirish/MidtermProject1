using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace MidtermProject1
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            {
                String connectionString1 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\giriz\source\repos\MidtermProject1\MidtermProject1\App_Data\midtermDB.mdf;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString1);
                conn.Open();

                String q = "select * from login where username ='" + TextBox1.Text + "' and password='" + TextBox2.Text + "' ";
                SqlCommand cmd = new SqlCommand(q, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                lblMessage.Visible = false;
                lblMessage0.Visible = false;
                int count = 0;
                while (dr.Read())
                {
                    ++count;
                }
                dr.Close();

                if (count == 0)
                {
                    lblMessage0.Visible = true;
                    lblMessage0.Text = "Either username or password is incorrect.Please try again.";
                }
                else
                {
                    lblMessage.Visible = true;
                    lblMessage.Text = "Successfull";
                }
                Response.Redirect("homepage.aspx");
            }
        }
    }
}