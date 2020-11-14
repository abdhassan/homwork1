﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace taqanat
{
    public partial class page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {// مشان عرض نتائج من page1
            this.TextBox1.Text = Request.QueryString[0];
            this.TextBox2.Text = Request.QueryString[1];
         
        
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CheckBox1.Checked = true;
        }

       

        protected void Butset_Click1(object sender, EventArgs e)
        {//viewstate 
            ViewState["first"] = txt1.Text;
            ViewState["last"] = txt2.Text;
            txt1.Text = txt2.Text ="";

        }

        

        protected void Butget_Click(object sender, EventArgs e)
        {
            txt1.Text = ViewState["first"].ToString();
            txt1.Text = ViewState["last"].ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {//cookie مع الصفحة 3
            HttpCookie my = new HttpCookie("password", "1,2,3,4,5");
            Response.Cookies.Add(my);
            Response.Redirect("page3.aspx");

        }

        protected void btnsession_Click(object sender, EventArgs e)
        {//sessionمع الصفحة 4
            Session["username"]="abd";
            Response.Redirect("page4.aspx");
        }

        protected void Btnapp_Click(object sender, EventArgs e)
        {//  Application مع الصفحة5
            Application["af"] = TextBox1.Text;
            Response.Redirect("page5.aspx");
        }
    }
}