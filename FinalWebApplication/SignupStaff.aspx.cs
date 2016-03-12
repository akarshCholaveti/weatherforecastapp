using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalWebApplication
{
    public partial class SignupStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AccountService.Service1Client addAccount = new AccountService.Service1Client();
            LocalComponentLayer ED = new LocalComponentLayer();
            string name = ED.Encrypt(TextBox1.Text);
            string email = ED.Encrypt(TextBox2.Text); 
            string username = ED.Encrypt(TextBox3.Text); 
            string password = ED.Encrypt(TextBox4.Text); 
            string address = ED.Encrypt(TextBox5.Text); 
            string phoneNumber = ED.Encrypt(TextBox6.Text);
            Session["UserName"] = TextBox3.Text;

            bool flag = addAccount.CreateAccount(name, email, username, password, address, phoneNumber);
            if (flag)
            {
                Response.Redirect("StaffHome.aspx");
            }
            else
            {
                this.Label6.Text = "*Account Creation failed";
            }
        }
    }
}