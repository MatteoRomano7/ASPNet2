using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNet2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie c = new HttpCookie("LOGIN");
            c.Values["username"] = TextBox1.Text;
            c.Expires = DateTime.Now.AddYears(4);
            Response.Cookies.Add(c);
            Response.Redirect("WebForm2.aspx");
        }
    }
}