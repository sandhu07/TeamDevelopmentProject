using System;
using System.Data;
using DayPilot.Web.Ui.Events.Calendar;
using BeforeCellRenderEventArgs = DayPilot.Web.Ui.Events.Navigator.BeforeCellRenderEventArgs;
using CommandEventArgs = DayPilot.Web.Ui.Events.CommandEventArgs;
using Class_Library;

public partial class _Default : System.Web.UI.Page 
{
    private DataTable _appointments;
    
    void DisplayAppointments()
    {
        clsAppointmentCollection Db = new clsAppointmentCollection();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadCalendarData();
            LoadNavigatorData();
        }
        
    }

    private void LoadNavigatorData()
    {
        if (_appointments == null)
        {
            LoadAppointments();
        }
        
        DayPilotNavigator1.DataSource = _appointments;
        DayPilotNavigator1.DataStartField = "AppointmentStart";
        DayPilotNavigator1.DataEndField = "AppointmentEnd";
        DayPilotNavigator1.DataIdField = "AppointmentId";
        DayPilotNavigator1.DataBind();
    }

    private void LoadCalendarData()
    {
        if (_appointments == null)
        {
            LoadAppointments();
        }

        HealthcareCalendar1.DataSource = _appointments;
        HealthcareCalendar1.DataStartField = "AppointmentStart";
        HealthcareCalendar1.DataEndField = "AppointmentEnd";
        HealthcareCalendar1.DataIdField = "AppointmentId";
        HealthcareCalendar1.DataTextField = "AppointmentPatientName";
        HealthcareCalendar1.DataTagFields = "AppointmentStatus";
        HealthcareCalendar1.DataBind();
        HealthcareCalendar1.Update();
    }

    private void LoadAppointments()
    {
        int id = Convert.ToInt32(Request.QueryString["id"]);  // basic validation
        _appointments = Db.LoadFreeAndMyAppointments(DayPilotNavigator1.VisibleStart, DayPilotNavigator1.VisibleEnd, Session.SessionID);
    }


    protected void DayPilotCalendar1_OnCommand(object sender, CommandEventArgs e)
    {
        switch (e.Command)
        {
            case "navigate":
                HealthcareCalendar1.StartDate = (DateTime) e.Data["day"];
                LoadCalendarData();
                break;
            case "refresh":
                LoadCalendarData();
                break;
        }
        
    }

    protected void HealthcareNavigator1_OnBeforeCellRender(object sender, BeforeCellRenderEventArgs e)
    {
    }

    protected void HealthcareCalendar1_OnBeforeEventRender(object sender, BeforeEventRenderEventArgs e)
    {
        string status = e.Tag["AppointmentStatus"];

        switch (status)
        {
            case "free":
                e.DurationBarColor = "green";
                e.Html = "Available";
                e.ToolTip = "Click to Request This Time Slot";
                break;
            case "waiting":
                e.DurationBarColor = "green";
                e.Html = "Your appointment, waiting for confirmation";
                break;
            case "confirmed":
                e.DurationBarColor = "#f41616";
                e.Html = "Your appointment, confirmed";
                break;
        }
    }

}
