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

        public ArrayList animals = new ArrayList();

        protected void Page_Load(object sender, EventArgs e)
        {
            lbl.Text = "TESTINGG 2";
            ArrayList values = new ArrayList();

            values.Add("Tree");
            values.Add("Bark");
            values.Add("Wood");

            Repeater1.DataSource = values;
            Repeater1.DataBind();

            string[] items = { "Ant", "Dog", "Cat" };

            foreach (string item in items)
            {
                animals.Add(item);
            }
            Repeater_Binder(animals, AnimalRepeater);
        }


        public void Repeater_Binder(ArrayList param1, Repeater repeater1)
        {
            repeater1.DataSource = param1;
            repeater1.DataBind();
        }

        public void Add_Animal(object sender, EventArgs e)
        {
            animals.Add(Text1.Text);
            Repeater_Binder(animals, AnimalRepeater);
        }
    }
}