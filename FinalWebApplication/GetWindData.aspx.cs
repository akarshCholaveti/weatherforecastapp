using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalWebApplication
{
    public partial class GetWindData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            WindService.Service1Client wind = new WindService.Service1Client();
            string windDetails = wind.WindIntensity(Decimal.Parse(TextBox1.Text), Decimal.Parse(TextBox2.Text));
            this.Label4.Text = "The wind Intesnity is:" + windDetails;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Member.aspx");
        }
    }
}