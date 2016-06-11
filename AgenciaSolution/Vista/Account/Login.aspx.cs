using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using Controlador;
using Vista.Models;

namespace Vista.Account
{
    public partial class Login : Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterHyperLink.NavigateUrl = "Register";
            // Enable this once you have account confirmation enabled for password reset functionality
            //ForgotPasswordHyperLink.NavigateUrl = "Forgot";
            OpenAuthLogin.ReturnUrl = Request.QueryString["ReturnUrl"];
            var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            if (!String.IsNullOrEmpty(returnUrl))
            {
                RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
            }
        }

        protected void LogIn(object sender, EventArgs e)
        {
            Boolean success = false;
            if (Email.Text != "" && Password.Text != "")
            {
                success=LoginDAO.validateLogin(Email.Text.Trim(), Password.Text.Trim());
                if (success)
                {
                    clearFields();
                    Response.Redirect("/Pages/Main");
                    string display = "Bienvenido";
                    ClientScript.RegisterStartupScript(this.GetType(), "yourMessage", "alert('" + display + "');", true);
                }
                else
                {
                    string display = "Login Incorrecto";
                    ClientScript.RegisterStartupScript(this.GetType(), "yourMessage", "alert('" + display + "');", true);
                }
            }

            else            {
                //lblMessage.Text = "Please make sure that the username and the password is Correct";
            }
        }

        private void clearFields()
        {
            Email.Text = "";
            Password.Text = "";
        }
    }
}