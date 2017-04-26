using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using Class_Library;

public partial class PatientRegister : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnRegister_Click1(object sender, EventArgs e)
    {
        //connect to classes
        clsDataConnection myDB = new clsDataConnection();
        //cls login instance
        clsLogin LoginRegister = new clsLogin();
        clsUser UserRegister = new clsUser();
        clsMedical MedicalRegister = new clsMedical();
        //if password is the same as confirm password update datatable

        LoginRegister.Username = txtUsername.Text;
        LoginRegister.Password = txtPassword.Text;
        LoginRegister.EmailAddress = txtEmail.Text;
        UserRegister.FirstName = txtFirstName.Text;
        UserRegister.Surname = txtFirstName.Text;
        UserRegister.Dob = txtFirstName.Text;
        UserRegister.HomeAddress = txtFirstName.Text;
        UserRegister.PostCode = txtFirstName.Text;
        MedicalRegister.Medication = txtMedication.Text;
        MedicalRegister.TravelInsurance = txtMedication.Text;
        MedicalRegister.GPName = ddlGPName.Text;
        MedicalRegister.LastGPVisit = txtMedication.Text;

        clsLoginCollection login = new clsLoginCollection();
        clsUserCollection user = new clsUserCollection();
        clsMedicalCollection medical = new clsMedicalCollection();

        if (login.AddLogin(LoginRegister) != -1)
        {
            lblError.Text = "You have registered";
            Response.Redirect("PatientLogin.aspx");
        }
        if (user.AddUser(UserRegister) != -1)
        { }
        if (medical.AddMedical(MedicalRegister) != -1)
        {
            lblError.Text = "Your have registered";
            Response.Redirect("PatientLogin.aspx");
        }

        //validate register and then redirect to login
        else
        {
            //show error in label
            lblError.Text = "Your passwords do not match";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to login page
        Response.Redirect("Login.aspx");
    }
}