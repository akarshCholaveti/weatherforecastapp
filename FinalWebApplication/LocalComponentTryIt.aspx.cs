using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalWebApplication
{
    public partial class LocalComponentTryIt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EncryptAndDecrypt.ServiceClient encrypt = new EncryptAndDecrypt.ServiceClient();
            Label1.Text = encrypt.Encrypt(TextBox1.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            EncryptAndDecrypt.ServiceClient decrypt = new EncryptAndDecrypt.ServiceClient();
            Label2.Text = decrypt.Decrypt(TextBox2.Text);
        }
    }
}