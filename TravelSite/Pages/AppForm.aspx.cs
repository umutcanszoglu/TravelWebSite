using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DatabaseAccessLayer.Operations;
using Models;

namespace TravelSite.Pages
{
    public partial class AppForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_OnClick(object sender, EventArgs e)
        {
            ApplicationFormDal formDal = new ApplicationFormDal();
            formDal.Add(new ApplicationForm
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                Email = txtEmail.Text,
                Message = txtMessage.Text
            });
        }
    }
}