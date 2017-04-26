<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Doctor.aspx.cs" Inherits="Doctor" MasterPageFile="~/Site.master"  %>
<%@ Register Assembly="DayPilot" Namespace="DayPilot.Web.Ui" TagPrefix="HealthCare" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <script type="text/javascript" src="Scripts/healthcare.js"></script>
	<script type="text/javascript" src="Scripts/jquery-1.9.1.js"></script>
    <link href='css/main.css' type="text/css" rel="stylesheet" /> 
</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    
<h3>Manage Doctor's Schedule</h3>
        
<div class="space">
    Select Doctor: 
    <asp:DropDownList runat="server" ID="DropDownListDoctor" AppendDataBoundItems="true" AutoPostBack="true" OnSelectedIndexChanged="DropDownListDoctor_OnSelectedIndexChanged">
            <asp:ListItem Value="NONE"></asp:ListItem>
    </asp:DropDownList>
</div>
    
<asp:Panel runat="server" ID="Schedule">
    <div style="float:left; width: 150px;">
        <HealthCare:DayPilotNavigator 
            runat="server" 
            ID="DayPilotNavigator1" 
            ClientIDMode="Static"
            BoundDayPilotID="DayPilotCalendar1"
            ShowMonths="1"    
            SelectMode="Week"
        
            OnBeforeCellRender="DayPilotNavigator1_OnBeforeCellRender"
            />  
    </div>
    
    <div style="margin-left: 150px;">
        <HealthCare:DayPilotCalendar 
            runat="server" 
            ID="DayPilotCalendar1"
            ClientObjectName="dp"
            ClientIDMode="Static"
            ViewType="WorkWeek"
        
            OnCommand="DayPilotCalendar1_OnCommand"
            TimeRangeSelectedHandling="CallBack"
            OnTimeRangeSelected="DayPilotCalendar1_OnTimeRangeSelected"
            OnBeforeEventRender="DayPilotCalendar1_OnBeforeEventRender"
            EventClickHandling="JavaScript"
            EventClickJavaScript="edit(e);"
            EventMoveHandling="CallBack"
            OnEventMove="DayPilotCalendar1_OnEventMove"
            EventResizeHandling="CallBack"
            OnEventResize="DayPilotCalendar1_OnEventResize" BusinessEndsHour="17" CrosshairColor="White" DayBeginsHour="9" DayEndsHour="17" Days="7" EventSelectColor="White" HourBorderColor="White" HourFontSize="14pt" HourHalfBorderColor="White" HourNameBackColor="White" HourNameBorderColor="White" LoadingLabelBackColor="White" LoadingLabelFontColor="White" LoadingLabelFontSize="" LoadingLabelText="" LoadingLabelVisible="False" NonBusinessBackColor="White" BackColor="White" CellSelectColor="White" DurationBarColor="White" HeightSpec="BusinessHoursNoScroll"
            />
    </div>
</asp:Panel>
    
    
<script>
function edit(e) {
    new Healthcare.Modal({
        onClosed: function(args) {
            if (args.result == "OK") {
                dp.commandCallBack('refresh');
            }
        }
    }).showUrl("Edit.aspx?id=" + e.id());
}
</script>
</asp:Content>