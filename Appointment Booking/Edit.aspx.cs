using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using Class_Library;
using Healthcare;

public partial class Edit : Page
{
    private DataRow dr;

    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        
        dr = Db.LoadAppointment(Convert.ToInt32(Request.QueryString["id"]));
        
        if (!IsPostBack)
        {

            txtStart.Text = Convert.ToDateTime(dr["AppointmentStart"]).ToString();
            txtEnd.Text = Convert.ToDateTime(dr["AppointmentEnd"]).ToString();
            txtName.Text = dr["AppointmentPatientName"] as string;
            ddlStatus.SelectedValue = (string)dr["AppointmentStatus"];
            
            ddlDoctor.DataSource = Db.LoadDoctors();
            ddlDoctor.DataTextField = "DoctorName";
            ddlDoctor.DataValueField = "DoctorId";
            ddlDoctor.SelectedValue = Convert.ToString(dr["DoctorId"]);
            ddlDoctor.DataBind();

            txtName.Focus();
        }
    }
    protected void ButtonOK_Click(object sender, EventArgs e)
    {
        DateTime start = (DateTime)dr["AppointmentStart"];
        DateTime end = (DateTime)dr["AppointmentEnd"];
        int doctor = (int) dr["DoctorId"];

        string name = txtName.Text;
        string status = ddlStatus.SelectedValue;

        int id = Convert.ToInt32(Request.QueryString["id"]);

        Db.UpdateAppointment(id, start, end, name, doctor, status);
        Modal.Close(this, "OK");
    }


    protected void ButtonCancel_Click(object sender, EventArgs e)
    {
        Modal.Close(this);
    }
    protected void LinkButtonDelete_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(Request.QueryString["id"]);
        Db.DeleteAppointment(id);
        Modal.Close(this, "OK");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(Request.QueryString["id"]);
        Db.DeleteAppointment(id);
        Modal.Close(this, "OK");
    }

    protected void ddlDoctor_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
