using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library;

public partial class PatientLogin : System.Web.UI.Page
{
    clsLogin LoginControl = new clsLogin();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsLogin aLogin = new clsLogin();
        aLogin.Username = txtUsername.Text;
        aLogin.Password = txtPassword.Text;

        clsLoginCollection login = new clsLoginCollection();


        //instance errormsg
        string ErrorMsg;
        //instance clslogin
        clsLogin Login = new clsLogin();
        //validate username and password
        ErrorMsg = Login.Validate(txtPassword.Text, txtUsername.Text);
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            //if blank then display error message
            {
                lblError.Text = "Username or Password is blank";
            }
            else
            //else validate username and password form clslogin
            {
                Boolean OK;
                OK = Login.Login(txtPassword.Text, txtUsername.Text);
                //if ok true then session login number and redirect
                if (OK == true)
                {
                    Session["LoginNo"] = Login.LoginNo;
                    Response.Redirect("PatientOptions.aspx");
                }
                //else display ErrorMsg in lbl
                else
                {
                    lblError.Text = ErrorMsg;
                }

            }
        }
    }

protected void btnRegister_Click(object sender, EventArgs e)
    {
            //redirect to register
            Response.Redirect("PatientRegister.aspx");

    }

    protected void btnPassword_Click(object sender, EventArgs e)
    {
        //redirect to register
        Response.Redirect("PatientPassword.aspx");

    }
}