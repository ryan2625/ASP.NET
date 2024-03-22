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

        private ArrayList animals;


        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                animals = new ArrayList();
                Session["Animals"] = animals;
                string[] items = { "Ant", "Dog", "Cat" };

                foreach (string item in items)
                {
                    animals.Add(item);
                }
                Repeater_Binder(animals, AnimalRepeater);

            } else
            {
                animals = (ArrayList)Session["Animals"];
                Repeater_Binder(animals, AnimalRepeater);
            }
        }

        public void Repeater_Binder(ArrayList param1, Repeater repeater1)
        {
            repeater1.DataSource = param1;
            repeater1.DataBind();
        }

        public void Add_Animal(object sender, EventArgs e)
        {
            animals.Add(Text1.Text);
            Text1.Text = "";
            Repeater_Binder(animals, AnimalRepeater);
        }

        public void Check_CheckB(object sender, EventArgs e)
        {
            Label1.Visible = false;
        }
    }
}