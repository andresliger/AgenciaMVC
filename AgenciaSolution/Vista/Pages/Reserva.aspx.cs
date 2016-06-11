using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista.Pages
{
    public partial class Reserva : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //Retrieve Selected Text from Dropdown
            //lblSelectedText.Text = ddlGender.SelectedItem.Text;

            //Retrieve Selected Value from Dropdown
            //lblSelectedValue.Text = ddlGender.SelectedValue;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            //TextBox1.Text = Calendar1.SelectedDate.ToString();
        }
    }
}