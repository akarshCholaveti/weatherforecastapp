using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalWebApplication
{
    public partial class ImageVerifier : System.Web.UI.UserControl
    {
        public string textBox
        {
            get
            {
                return TextBox1.Text;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ImageVerifierService.ServiceClient imgVerifier = new ImageVerifierService.ServiceClient();
                string imageText = "";
                imageText = imgVerifier.GetVerifierString("4");
                this.Image1.ImageUrl = "http://venus.eas.asu.edu/WSRepository/Services/ImageVerifier/Service.svc//GetImage/" + imageText;
                Session["captcha"] = imageText;
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ImageVerifierService.ServiceClient imgVerifier = new ImageVerifierService.ServiceClient();
            string imageText = "";
            imageText = imgVerifier.GetVerifierString("4");
            this.Image1.ImageUrl = "http://venus.eas.asu.edu/WSRepository/Services/ImageVerifier/Service.svc//GetImage/" + imageText;
            Session["captcha"] = imageText;
        }
    }
}