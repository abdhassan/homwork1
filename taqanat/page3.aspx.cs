﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace taqanat
{
    public partial class page3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Textcoo.Text = Request.Cookies["password"].Value;
           
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}