using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace taqanat
{
    public partial class page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            TextBox2.Text = TextBox1.Text;
            TextBox1.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("page2.aspx");

            
        }

        protected void Button3_Click(object sender, EventArgs e)
        { //quristring
            Response.Redirect
          ("page2.aspx? name="+this.name.Text + "&" + this.lastname.Text);
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}