using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using Class_Library;
using Healthcare;

public partial class Request : Page
{
    private DataRow dr;

    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        
        dr = Db.LoadAppointment(Convert.ToInt32(Request.QueryString["id"]));
        
        if (!IsPostBack)
        {

            TextBoxStart.Text = Convert.ToDateTime(dr["AppointmentStart"]).ToString();
            TextBoxEnd.Text = Convert.ToDateTime(dr["AppointmentEnd"]).ToString();
            TextBoxName.Text = dr["AppointmentPatientName"] as string;

            ddlDoctor.DataSource = Db.LoadDoctors();
            ddlDoctor.DataTextField = "DoctorName";
            ddlDoctor.DataValueField = "DoctorId";
            ddlDoctor.SelectedValue = Convert.ToString(dr["DoctorId"]);
            ddlDoctor.DataBind();

            TextBoxName.Focus();
        }
    }
    protected void ButtonOK_Click(object sender, EventArgs e)
    {
        string name = TextBoxName.Text;

        int id = Convert.ToInt32(Request.QueryString["id"]);

        Db.RequestAppointment(id, name, Session.SessionID);
        Modal.Close(this, "OK");
    }


    protected void ButtonCancel_Click(object sender, EventArgs e)
    {
        Modal.Close(this);
    }
    protected void LinkButtonDelete_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(Request.QueryString["id"]);
        Db.DeleteAppointmentIfFree(id);
        Modal.Close(this, "OK");
    }
}
