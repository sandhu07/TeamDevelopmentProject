﻿using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections;
using System.Collections.Generic;


namespace Class_Library
{
   
    public class clsEventCalendar : System.Web.UI.WebControls.Calendar
    {
        
        // **********************************************************
        // Gets or Sets the Name of source DataTable  
        /// <summary>
        /// If this is specified, then EventDate and EventHeader are mandatory
        /// </summary>
        public DataTable EventSource
        {
            get
            {
                if (ViewState["EventSource"] == null)
                    return null;
                else
                    return ((DataTable)ViewState["EventSource"]);
            }
            set { ViewState["EventSource"] = value; }
        }
        // **********************************************************

        // **********************************************************
        // Gets or sets the Date Column in the DataTable
        public string EventStartDateColumnName
        {
            get
            {
                if (ViewState["StartDateColumnName"] == null)
                    return string.Empty;
                else
                    return (ViewState["StartDateColumnName"].ToString());
            }
            set { ViewState["StartDateColumnName"] = value; }
        }
        // **********************************************************

        // **********************************************************
        // Gets or sets the Date Column in the DataTable
        public string EventEndDateColumnName
        {
            get
            {
                if (ViewState["EndDateColumnName"] == null)
                    return string.Empty;
                else
                    return (ViewState["EndDateColumnName"].ToString());
            }
            set { ViewState["EndDateColumnName"] = value; }
        }
        // **********************************************************

        // **********************************************************
        // Gets or sets the Event Header Column Name in the DataTable
        public string EventHeaderColumnName
        {
            get
            {
                if (ViewState["EventHeaderColumnName"] == null)
                    return string.Empty;
                else
                    return (ViewState["EventHeaderColumnName"].ToString());
            }
            set { ViewState["EventHeaderColumnName"] = value; }
        }
        // **********************************************************

        // **********************************************************
        // Gets or sets the Event Description Column Name in the DataTable
        public string EventDescriptionColumnName
        {
            get
            {
                if (ViewState["EventDescriptionColumnName"] == null)
                    return string.Empty;
                else
                    return (ViewState["EventDescriptionColumnName"].ToString());
            }
            set { ViewState["EventDescriptionColumnName"] = value; }
        }
        // **********************************************************

        // **********************************************************
        // Gets or sets the Event Description Column Name in the DataTable
        public bool ShowDescriptionAsToolTip
        {
            get
            {
                if (ViewState["EventDescriptionColumnName"] == null)
                    return true;
                else
                    return (Convert.ToBoolean(ViewState["ShowDescriptionAsToolTip"].ToString()));
            }
            set { ViewState["ShowDescriptionAsToolTip"] = value; }
        }
        // **********************************************************

        // **********************************************************
        // Gets or sets the Event Back Color Column Name in the DataTable
        public string EventBackColorName
        {
            get
            {
                if (ViewState["EventBackColorName"] == null)
                    return string.Empty;
                else
                    return (ViewState["EventBackColorName"].ToString());
            }
            set { ViewState["EventBackColorName"] = value; }
        }
        // **********************************************************
        // **********************************************************
        // Gets or sets the Event Fore Color Column Name in the DataTable
        public string EventForeColorName
        {
            get
            {
                if (ViewState["EventForeColorName"] == null)
                    return string.Empty;
                else
                    return (ViewState["EventForeColorName"].ToString());
            }
            set { ViewState["EventForeColorName"] = value; }
        }
        // **********************************************************

        public EventCalendar() : base()
        {
            DayRender += new DayRenderEventHandler(EventCalendarDayRender);
        }

        protected void EventCalendarDayRender(object sender, DayRenderEventArgs e)
        {
            CalendarDay d = ((DayRenderEventArgs)e).Day;
            TableCell c = ((DayRenderEventArgs)e).Cell;

            // If there is nothing to bind
            if (this.EventSource == null)
                return;

            DataTable dt = this.EventSource;

            foreach (DataRow dr in dt.Rows)
            {
                if (EventStartDateColumnName == string.Empty)
                    throw new ApplicationException("Must set EventCalendar's EventStartDateColumnName property when EventSource is specified");
                if (EventEndDateColumnName == string.Empty)
                    throw new ApplicationException("Must set EventCalendar's EventEndDateColumnName property when EventSource is specified");
                if (EventHeaderColumnName == string.Empty)
                    throw new ApplicationException("Must set EventCalendar's EventHeaderColumnName property when EventSource is specified");


                if (!d.IsOtherMonth
                    && d.Date >= Convert.ToDateTime(dr[this.EventStartDateColumnName]).Date
                    && d.Date <= Convert.ToDateTime(dr[this.EventEndDateColumnName]).Date)
                {
                    System.Web.UI.WebControls.Label lbl = new System.Web.UI.WebControls.Label();

                    // Show the Event Text
                    lbl.Text = "<BR />" + dr[EventHeaderColumnName].ToString();

                    // Set the Tool Tip
                    if (this.ShowDescriptionAsToolTip && this.EventDescriptionColumnName != string.Empty)
                        lbl.ToolTip = dr[EventDescriptionColumnName].ToString();

                    // Set the Back Color of the Label
                    if (EventBackColorName != null && dr[EventBackColorName] != null && dr[EventBackColorName] != "")
                        lbl.BackColor = System.Drawing.Color.FromName(dr[EventBackColorName].ToString());
                    // Set the Fore Color
                    if (EventForeColorName != null && dr[EventForeColorName] != null && dr[EventForeColorName] != "")
                        lbl.ForeColor = System.Drawing.Color.FromName(dr[EventForeColorName].ToString());
                    c.Controls.Add(lbl);


                }
            }
        }
    }
}
