using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace MidtermProject1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\giriz\source\repos\MidtermProject1\MidtermProject1\App_Data\midtermDB.mdf;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO registration (fname,lname,contact,email,username,password,confirmpass) values (@value1, @value2, @value3,@value4,@value5,@value6,@value7)", connection);
            SqlCommand cmdo = new SqlCommand("INSERT INTO login (username,password) values (@value8,@value9)", connection);
            cmd.Parameters.AddWithValue("@value1", TextBox1.Text);
            cmd.Parameters.AddWithValue("@value2", TextBox2.Text);
            cmd.Parameters.AddWithValue("@value3", TextBox3.Text);
            cmd.Parameters.AddWithValue("@value4", TextBox4.Text);
            cmd.Parameters.AddWithValue("@value5", TextBox5.Text);
            cmd.Parameters.AddWithValue("@value6", TextBox6.Text);
            cmd.Parameters.AddWithValue("@value7", TextBox7.Text);
            cmdo.Parameters.AddWithValue("@value8", TextBox5.Text);
            cmdo.Parameters.AddWithValue("@value9", TextBox6.Text);
            cmd.ExecuteNonQuery();
            cmdo.ExecuteNonQuery();

            connection.Close();
            lblMessage.Text = "Data inserted successfully";
            Response.Redirect("login.aspx");
        }
    }
}