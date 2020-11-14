using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace taqanat
{
    public partial class field : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {// ملف مخفي
            string h = TextBox1.Text;
            HiddenField1.Value = h;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string l = HiddenField1.Value;
            Response.Write(l);
        }
    }
}