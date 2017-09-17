using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fileUpload
{
    public partial class first : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                String extension = System.IO.Path.GetExtension(FileUpload1.FileName);

                if (extension.ToLower() != ".txt" && extension.ToLower() != ".doc")
                {
                    Label1.Text = "only txt or docx files!!";
                    Label1.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int filesize = FileUpload1.PostedFile.ContentLength;
                    if (filesize > 2097152)
                    {

                        Label1.Text = "only less than 2 mb";
                        Label1.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        FileUpload1.SaveAs(Server.MapPath("~/uploads/" + FileUpload1.FileName));
                        Label1.Text = "file uploaded!!";
                        Label1.ForeColor = System.Drawing.Color.Green;
                    }
                }
            }
            else
            {
                Label1.Text = "select a file to upload!!";
                Label1.ForeColor = System.Drawing.Color.Red;
            }

        }
    }
}