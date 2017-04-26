<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="EventCalendar.aspx.cs" Inherits="EventCalendar" %>
<%@ Register TagPrefix="ECalendar" Namespace="Class_Library" Assembly="Class Library" %>


<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 38%;
            height: 173px;
            position: absolute;
            top: 212px;
            left: 259px;
            right: 212px;
            z-index: 1;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
    </p>

    <div>
        &nbsp;<asp:GridView ID="gvSelectedDateEvents" runat="server" Width="30%" Height="61px">
        </asp:GridView>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />

        <asp:Calendar ID="Calendar1" runat="server" CssClass="auto-style1" BackColor="White" BorderColor="Silver"
                       BorderWidth="1px" Font-Names="Verdana" ClientIDMode="Static" ClientObjectName="hc" ViewType="WorkWeek"
             OnCommand="DayPilotCalendar1_OnCommand"         OnBeforeEventRender="DayPilotCalendar1_OnBeforeEventRender"
                    EventClickHandling="JavaScript"
        EventClickJavaScript="edit(e)" BusinessEndsHour="17" CellSelectColor="White" CrosshairColor="White" DayBeginsHour="9" DayEndsHour="17" HeightSpec="BusinessHoursNoScroll" HourNameBorderColor="White" LoadingLabelBackColor="White" LoadingLabelFontColor="White" LoadingLabelFontSize="0" LoadingLabelText="" LoadingLabelVisible="False" NonBusinessBackColor="White" HourBorderColor="White" HourHalfBorderColor="White" HourNameBackColor="White" UseEventBoxes="Never" ViewStateMode="Disabled" DurationBarColor="White" EventFontColor="White" EventSelectColor="White" HeaderHeight="15" HourFontFamily="Arial" HourFontSize="12pt" ScrollDownLabelText="" ScrollLabelsVisible="False" ScrollUpLabelText="" Width="252px"
            Font-Size="9pt" ForeColor="Black" FirstDayOfWeek="Monday" NextMonthText="Next &gt;" PrevMonthText="&lt; Prev" ShowGridLines="True" NextPrevFormat="ShortMonth" 
            ShowDescriptionAsToolTip="True" BorderStyle="Solid" EventDateColumnName="" EventDescriptionColumnName="" EventHeaderColumnName="" OnSelectionChanged="Calendar1_SelectionChanged" OnDataBinding="Calendar1_DataBinding" OnDayRender="Calendar1_DayRender">
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TodayDayStyle BackColor="#CCCCCC" />
            <SelectorStyle BorderColor="#404040" BorderStyle="Solid" />
            <DayStyle HorizontalAlign="Left" VerticalAlign="Top" Wrap="True" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <NextPrevStyle Font-Size="8pt" ForeColor="#333333" Font-Bold="True" VerticalAlign="Bottom" />
            <DayHeaderStyle BorderWidth="1px" Font-Bold="True" Font-Size="8pt" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True"
                Font-Size="12pt" ForeColor="#333399" HorizontalAlign="Center" VerticalAlign="Middle" />


        </asp:Calendar>
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

