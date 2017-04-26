using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using ExtendedControls;


public partial class _Default : System.Web.UI.Page
{

    private DataTable GetEvents()
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("Id", Type.GetType("System.Int32"));
        dt.Columns.Add("EventStartDate", Type.GetType("System.DateTime"));
        dt.Columns.Add("EventEndDate", Type.GetType("System.DateTime"));
        dt.Columns.Add("EventHeader", Type.GetType("System.String"));
        dt.Columns.Add("EventDescription", Type.GetType("System.String"));
        dt.Columns.Add("EventForeColor", Type.GetType("System.String"));
        dt.Columns.Add("EventBackColor", Type.GetType("System.String"));

        int idCount = 1;

        DataRow dr;

        // Yesterday's Events
        dr = dt.NewRow();
        dr["Id"] = idCount++;
        dr["EventStartDate"] = DateTime.Now.AddDays(-1);
        dr["EventEndDate"] = DateTime.Now.AddDays(-1);
        dr["EventHeader"] = "My Yesterday's Single Day Event";
        dr["EventDescription"] = "My Yesterday's Single Day Event Details";
        dr["EventForeColor"] = "White";
        dr["EventBackColor"] = "Navy";
        dt.Rows.Add(dr);

        // Three Day's Event Starting Tomorrow
        dr = dt.NewRow();
        dr["Id"] = idCount++;
        dr["EventStartDate"] = DateTime.Now.AddDays(1);
        dr["EventEndDate"] = DateTime.Now.AddDays(+3);
        dr["EventHeader"] = "My Three Days Event";
        dr["EventDescription"] = "My Three Days Event Details, which starts tomorrow";
        dr["EventForeColor"] = "White";
        dr["EventBackColor"] = "Green";
        dt.Rows.Add(dr);


        return dt;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        Calendar1.EventStartDateColumnName = "EventStartDate";
        Calendar1.EventEndDateColumnName = "EventEndDate";
        Calendar1.EventDescriptionColumnName = "EventDescription";
        Calendar1.EventHeaderColumnName = "EventHeader";
        Calendar1.EventBackColorName = "EventBackColor";
        Calendar1.EventForeColorName = "EventForeColor";


        Calendar1.EventSource = GetEvents();
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
}