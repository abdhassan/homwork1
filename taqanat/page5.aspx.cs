using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace taqanat
{
    public partial class page5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         Label1.Text=  Application["af"].ToString();

        }

    
    }
}