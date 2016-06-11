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
            //if (IsValid)
            //{
            //    // Validate the user password
            //    var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            //    var signinManager = Context.GetOwinContext().GetUserManager<ApplicationSignInManager>();

            //    // This doen't count login failures towards account lockout
            //    // To enable password failures to trigger lockout, change to shouldLockout: true
            //    var result = signinManager.PasswordSignIn(Email.Text, Password.Text, false, shouldLockout: false);

            //    switch (result)
            //    {
            //        case SignInStatus.Success:
            //            IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
            //            break;
            //        case SignInStatus.LockedOut:
            //            Response.Redirect("/Account/Lockout");
            //            break;
            //        case SignInStatus.RequiresVerification:
            //            Response.Redirect(String.Format("/Account/TwoFactorAuthenticationSignIn?ReturnUrl={0}&RememberMe={1}", 
            //                                            Request.QueryString["ReturnUrl"],
            //                                            false),
            //                              true);
            //            break;
            //        case SignInStatus.Failure:
            //        default:
            //            FailureText.Text = "Invalid login attempt";
            //            ErrorMessage.Visible = true;
            //            break;
            //    }
            //}

            Boolean success = false;
            if (Email.Text != "" && Password.Text != "")
            {
                success=LoginDAO.validateLogin(Email.Text.Trim(), Password.Text.Trim());
                if (success)
                {
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
    }
}