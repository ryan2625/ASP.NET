using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp_app
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl.Text = "TESTINGG 2";
            ArrayList values = new ArrayList();

            values.Add("Tree");
            values.Add("Bark");
            values.Add("Wood");

            Repeater1.DataSource = values;
            Repeater1.DataBind();
        }
    }
}