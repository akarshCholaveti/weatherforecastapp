using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalWebApplication
{
    public partial class WeatherForecast : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            WeatherService.Service1Client forecast = new WeatherService.Service1Client();
            string[] forecastDetails = forecast.WeatherForecast(TextBox1.Text);
            BulletedList1.DataSource = forecastDetails;
            BulletedList1.DataBind();
            BulletedList1.Enabled = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Member.aspx");
        }
    }
}