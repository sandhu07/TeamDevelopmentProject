using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Class_Library;
using DayPilot.Web.Ui.Events.Calendar;
using BeforeCellRenderEventArgs = DayPilot.Web.Ui.Events.Navigator.BeforeCellRenderEventArgs;
using CommandEventArgs = DayPilot.Web.Ui.Events.CommandEventArgs;


using System.Drawing;

public partial class EventCalendar : System.Web.UI.Page
{
    private DataTable _appointments();
    
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

        Calendar1.DataSource = _appointments;
        Calendar1.DataStartField = "AppointmentStart";
        Calendar1.DataEndField = "AppointmentEnd";
        Calendar1.DataIdField = "AppointmentId";
        Calendar1.DataTextField = "AppointmentPatientName";
        Calendar1.DataTagFields = "AppointmentStatus";
        Calendar1.DataBind();
        Calendar1.Update();
    }

    private void LoadAppointments()
    {
        int id = Convert.ToInt32(Request.QueryString["id"]);  // basic validation
        _appointments = Db.LoadFreeAndMyAppointments(DayPilotNavigator1.VisibleStart, DayPilotNavigator1.VisibleEnd, Session.SessionID);
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        SelectedDatesCollection theDates = Calendar1.SelectedDates;
        DataTable dtSelectedDateEvents = Calendar1.EventSource.Clone();
        DataRow dr;

        foreach (DataRow drEvent in Calendar1.EventSource.Rows)
            foreach (DateTime selectedDate in theDates)
                if (selectedDate.Date >= (Convert.ToDateTime(drEvent[Calendar1.EventStartDateColumnName])).Date
                    && selectedDate.Date <= (Convert.ToDateTime(drEvent[Calendar1.EventEndDateColumnName])).Date)
                {
                    // This Condition is just to ensure that Every Event Details are added just only once
                    // irrespective of the number of days for which the event occurs.
                    if (dtSelectedDateEvents.Select("Id= " + Convert.ToInt32(drEvent["Id"])).Length > 0)
                        continue;

                    dr = dtSelectedDateEvents.NewRow();
                    dr["Id"] = drEvent["Id"];
                    dr[Calendar1.EventStartDateColumnName] = drEvent[Calendar1.EventStartDateColumnName];
                    dr[Calendar1.EventEndDateColumnName] = drEvent[Calendar1.EventEndDateColumnName];
                    dr[Calendar1.EventHeaderColumnName] = drEvent[Calendar1.EventHeaderColumnName];
                    dr[Calendar1.EventDescriptionColumnName] = drEvent[Calendar1.EventDescriptionColumnName];

                    dr[Calendar1.EventForeColorName] = drEvent[Calendar1.EventForeColorName];
                    dr[Calendar1.EventBackColorName] = drEvent[Calendar1.EventBackColorName];

                    dtSelectedDateEvents.Rows.Add(dr);
                }

        gvSelectedDateEvents.DataSource = dtSelectedDateEvents;
        gvSelectedDateEvents.DataBind();

    }

    protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
    {

    }

    protected void Calendar1_DataBinding(object sender, EventArgs e)
    {

    }
}