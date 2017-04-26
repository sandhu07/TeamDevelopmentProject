<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="PatientOptions.aspx.cs" Inherits="_Default" MasterPageFile="~/Site.master"  %>
<%@ Register Assembly="DayPilot" Namespace="DayPilot.Web.Ui" TagPrefix="DayPilot" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    </asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent" ClientIDMode="Inherit">
    
    <h3>Search Appointment Booking</h3>
    
<div style="float:left; width: 150px;">
    <DayPilot:DayPilotNavigator
        runat="server" 
        ID="DayPilotNavigator1" 
        ClientIDMode="Static"
        BoundDayPilotID="DayPilotCalendar1"
        ShowMonths="1"    
        SelectMode="Week"
        
        OnBeforeCellRender="DayPilotNavigator1_OnBeforeCellRender" Height="181px"        
        />  
</div>
    
<div style="margin-left: 150px;">
    
    <DayPilot:DayPilotCalendar 
        runat="server" 
        ID="HealthcareCalendar1"
        ClientIDMode="Static"
        ClientObjectName="hc"
        ViewType="WorkWeek"
        
        DurationBarWidth="5"
        
        OnCommand="DayPilotCalendar1_OnCommand"
        OnBeforeEventRender="DayPilotCalendar1_OnBeforeEventRender"
        
        EventClickHandling="JavaScript"
        EventClickJavaScript="edit(e)" BackColor="White" BusinessEndsHour="17" CellSelectColor="White" CrosshairColor="White" DayBeginsHour="9" DayEndsHour="17" HeightSpec="BusinessHoursNoScroll" HourNameBorderColor="White" LoadingLabelBackColor="White" LoadingLabelFontColor="White" LoadingLabelFontSize="0" LoadingLabelText="" LoadingLabelVisible="False" NonBusinessBackColor="White" HourBorderColor="White" HourHalfBorderColor="White" HourNameBackColor="White" UseEventBoxes="Never" ViewStateMode="Disabled" CssClass="auto-style1" DurationBarColor="White" EventFontColor="White" EventSelectColor="White" HeaderHeight="15" HourFontFamily="Arial" HourFontSize="12pt" ScrollDownLabelText="" ScrollLabelsVisible="False" ScrollUpLabelText="" style="left: 0px; top: 0px; height: 363px;" ColumnMarginRight="3" ColumnWidth="80" ColumnWidthSpec="Fixed"
        />
</div>    

<div style="margin-left: 150px;">
    
</div> 
    
<script>
    function edit(e) {
        new Healthcare.Modal({
            onClosed: function (args) {
                if (args.result == "OK") {
                    hc.commandCallBack('refresh');
                }
            }
        }).showUrl("Request.aspx?id=" + e.id());
    }
</script>

</asp:Content>