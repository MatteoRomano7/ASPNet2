using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNet2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie c = Request.Cookies["LOGIN"];
            if (c != null)
            {
                string name = c.Values["username"];
                Response.Write($"Benvenuto {name}!");
            }
            else
            {
                Response.Redirect("WebForm1.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie c = Request.Cookies["LOGIN"];
            c.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(c);
            Response.Redirect("WebForm1.aspx");
        }
    }
}