using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DatabaseAccessLayer.Operations;

namespace TravelSite.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_OnClick(object sender, EventArgs e)
        {
            AdminDal adminDal = new AdminDal();
            var admin = adminDal.GetAdmin();

            if (txtEmail.Text == admin.Email && txtPassword.Text == admin.Password)
            {
                Response.Redirect("Admin.aspx");
            }
        }
    }
}