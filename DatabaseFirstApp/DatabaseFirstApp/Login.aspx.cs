using SecrecyHashPassword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DatabaseFirstApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var db = new DatabaseAppDataContext();

            dynamic Login = from user u in db.users select u;

            foreach (user a in Login)
            {
                if (a.Username.Equals(txtLoginUsername.Text) && a.Password.Equals(Secrecy.HashPassword(txtLoginPassword.Text)))
                {
                    //create session.
                    Session["username"] = a.Username;
                    Response.Redirect("Welcome.aspx");
                }
            }

            //use error message tag to show errors.
        }
    }
}