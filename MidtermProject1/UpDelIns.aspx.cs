using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace MidtermProject1
{
    public partial class UpDelIns : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\giriz\source\repos\MidtermProject1\MidtermProject1\App_Data\midtermDB.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into updelete values('"+ TextBox1.Text +"','"+ TextBox2.Text +"','"+ TextBox3.Text +"','"+ TextBox4.Text +"','"+ TextBox5.Text +"' )";
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("UpdelIns.aspx");
        }
    }
}