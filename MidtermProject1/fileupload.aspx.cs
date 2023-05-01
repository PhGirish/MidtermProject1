using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;


namespace MidtermProject1
{
    public partial class fileupload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string extension = System.IO.Path.GetExtension(FileUpload1.FileName);
            if (extension == ".jpg" || extension == ".png")
            {
               Label1.Visible = true;
                FileUpload1.SaveAs(Request.PhysicalApplicationPath + "\\fileUploads\\" + FileUpload1.FileName.ToString());
              Label1.Text = "File Uploaded Successfully: " + FileUpload1.FileName;
                Image1.ImageUrl = "~\\fileUploads\\" + FileUpload1.FileName;
            }
            else
            {
                Response.Write("<script>alert('You haven't selected an image or you’ve chosen the wrong file type. Only .JPG or .PNG images supported')</script>");
            }

        }
    }
}