using SecrecyHashPassword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DatabaseFirstApp
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            var db = new DatabaseAppDataContext();

            dynamic Register = from user u in db.users select u;

            bool IsRegistered = false;

            if (txtRegPassword.Text.Equals(txtRegConPassword.Text))
            {
                foreach (user a in Register)
                {
                    if (a.Username.Equals(txtRegUsername.Text) && a.Password.Equals(Secrecy.HashPassword(txtRegPassword.Text)))
                    {
                        IsRegistered = true;
                        report.InnerHtml = "<label> User already exists </label>";
                    }
                    
                }

                if (!IsRegistered)
                {
                    string userType = "";

                    if (radClient.Checked)
                    {
                        userType = radClient.Value;
                    }
                    else
                    {
                        userType = radDriver.Value;
                    }
                     

                    var AddUser = new user
                    {
                        Full_Name = txtRegFullname.Text,
                        Surname = txtRegSurname.Text,
                        Username = txtRegUsername.Text,
                        User_Type = userType,
                        Password = Secrecy.HashPassword(txtRegPassword.Text)
                    };

                    
                    db.users.InsertOnSubmit(AddUser);

                    try
                    {
                        db.SubmitChanges();
                        Session["username"] = txtRegUsername.Text;
                        Response.Redirect("Welcome.aspx");
                    }
                    catch (Exception ex)
                    {
                        ex.GetBaseException();
                    }
                }
            }
            else
            {
                report.InnerHtml = "<label> Password does not match </label>";
            }
        }
    }
}