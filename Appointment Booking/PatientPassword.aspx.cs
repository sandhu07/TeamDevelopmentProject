using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using Class_Library;

public partial class PatientPassword : System.Web.UI.Page
{
    //instance cls login
    clsLogin LoginControl = new clsLogin();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnPassword_Click(object sender, EventArgs e)
    {
        lblEmail.Visible = true;
        txtEmail.Visible = true;
        if (txtEmail.Text != "")
        {
            //create a variable to store your email
            var fromAddress = new MailAddress("turbo.tecnik@gmail.com", "Turbo Technik Ltd");
            //create a var to store to address details. copy txt email and customer
            var toAddress = new MailAddress(txtEmail.Text, "Dear Customer");
            //password for the company emial string
            const string fromPassword = "Turbo Technik Ltd";
            //subject for the email
            const string subject = "Turbo Technik Ltd";
            //body of the email
            const string body = "Your Password is = ";
            //create var to store smtpClient
            var smtp = new SmtpClient
            {
                //host for the email 
                Host = "smtp.gmail.com",
                //port number for the email
                Port = 587,
                //enableSsl set to true, speicty if its encrypted or now
                EnableSsl = true,
                //the delivery method of sending the email
                DeliveryMethod = SmtpDeliveryMethod.Network,
                //use default credentials set to false
                UseDefaultCredentials = false,
                //assign the credentials with from addresss and password
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                //subject of the email
                Subject = subject,
                //body of the email
                Body = body
            })
            {
                //send the email 
                smtp.Send(message);
                //show message box to say email sent
                lblError.Text = ("Your email has been sent!");
            }
        }
        else
        {
            //else display error
            lblError.Text = ("You need to enter an Gmail email address");
        }
    }

    protected void btnNewPassword_Click(object sender, EventArgs e)
    {
        lblError.Text = ("Password has been updated. Click 'Back' to login");
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("PatientLogin.aspx");
    }
}