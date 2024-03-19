using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp_app
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string greeting = "Welcome to our contact page!";
            DisplayMessage(greeting);

        }

        private void DisplayMessage(string message)
        {
            Label lblMessage = new Label();
            lblMessage.Text = message;

            this.Controls.Add(lblMessage);
        }

        public void Check_Clicked(object sender, EventArgs e)
        {
            Label lblMessage2 = new Label();
            lblMessage2.Text = "THIS IS CLICKED";

            this.Controls.Add(lblMessage2);
        }
    }
}