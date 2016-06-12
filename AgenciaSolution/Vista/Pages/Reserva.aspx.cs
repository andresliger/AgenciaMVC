﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista.Pages
{
    public partial class Reserva : System.Web.UI.Page
    {
        public static Decimal IVA = new Decimal(0.14);

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
            emptyFields();

        }

        protected void dropTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            emptyFields();
        }

        protected void SqlDataSource2_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void dropTarifasDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            Decimal subtotal = Convert.ToDecimal(dropTarifasDisponibles.SelectedValue.ToString()) * Convert.ToDecimal(txtNumero.Text);
            Decimal ivaSubtotal;
            Decimal total;
            txtSubtotal.Text = subtotal.ToString();
            ivaSubtotal = Convert.ToDecimal(txtSubtotal.Text) * IVA; 
            txtIVA.Text = ivaSubtotal.ToString();
            total = Convert.ToDecimal(txtSubtotal.Text) + Convert.ToDecimal(txtIVA.Text);
            txtTotal.Text = total.ToString();
            btnReservar.Visible = true;
        }

        protected void ReservarVuelo(object sender, EventArgs e)
        {

        }

        public void emptyFields()
        {
            txtSubtotal.Text = "";
            txtIVA.Text = "";
            txtTotal.Text = "";
            dropTarifasDisponibles.Items.Clear();
            btnReservar.Visible = false;
        }
    }
}