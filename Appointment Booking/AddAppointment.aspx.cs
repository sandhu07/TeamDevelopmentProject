using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library;
using System.Data;
using DayPilot.Web.Ui.Events.Calendar;
using BeforeCellRenderEventArgs = DayPilot.Web.Ui.Events.Navigator.BeforeCellRenderEventArgs;
using CommandEventArgs = DayPilot.Web.Ui.Events.CommandEventArgs;

public partial class AddAppointment : System.Web.UI.Page
{
    private DataTable _appointments;

    void DisplayAppointments()
    {
        clsAppointmentCollection Appointments = new clsAppointmentCollection();

    }

    protected void Page_Load(object sender, EventArgs e)
    {
        LoadNavigatorData();
    }

    private void LoadNavigatorData()
    {
    }

    protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
    {
        if (e.Day.Date.Day == 7)
            e.Cell.Font.Bold = true;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Calendar1.Visible = true;
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        TextBox1.Text = Calendar1.SelectedDate.ToShortDateString();
        Calendar1.Visible = false;
    }
}