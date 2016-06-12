﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controlador;

namespace Vista.Pages
{
    public partial class Vuelos : System.Web.UI.Page
    {
        private VuelosDAO objV = new VuelosDAO();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            //TextBox1.Text = Calendar1.SelectedDate.ToString();
        }

        protected void AgregarVuelo(object sender, EventArgs e)
        {
            Boolean success = false;
            if (validarCampos())
            {
                success = objV.registrarVuelo(Origen.SelectedValue, Destino.SelectedValue, "2", Salida.SelectedDate, Llegada.SelectedDate, int.Parse(Capacidad.Text));
                if (success)
                {
                    cleanFields();
                    ScriptManager.RegisterStartupScript(this, GetType(), "Información", "alert('Registro realizado con éxito.');", true);
                    GridView1.DataBind();
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Error", "alert('Ha ocurrido un error - Intente de nuevo.');", true);
            }
        }

        private Boolean validarCampos()
        {
            if (Origen.SelectedIndex == 0)
            {
                return false;
            }
            if (Destino.SelectedIndex == 0)
            {
                return false;
            }
            //if (Salida.SelectedDate != null)
            //{
            //    return false;
            //}
            //if (Llegada.SelectedDate != null)
            //{
            //    return false;
            //}
            if (Capacidad.Text == "")
            {
                return false;
            }
            return true;
        }

        private void cleanFields()
        {
            Origen.SelectedIndex = 0;
            Destino.SelectedIndex = 0;
            Salida = null;
            Llegada = null;
            Capacidad.Text = "";
        }

    }
}