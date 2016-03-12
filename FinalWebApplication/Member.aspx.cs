using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalWebApplication
{
    public partial class Member : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignupStaff.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            AccountService.Service1Client login = new AccountService.Service1Client();
            LocalComponentLayer lc = new LocalComponentLayer();
            string username = lc.Encrypt(TextBox1.Text);
            string password = lc.Encrypt(TextBox2.Text);
            Session["UserName"] = TextBox1.Text;
            bool flag = login.Login(username, password);
            if (flag)
            {
                Response.Redirect("StaffHome.aspx");
            }
            else
            {
                this.Label3.Text = "Invalid Staff user name or password";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Account/Login.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}