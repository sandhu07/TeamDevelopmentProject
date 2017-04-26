<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ Register TagPrefix="ECalendar" Namespace="ExtendedControls" Assembly="App_Code" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp;<asp:GridView ID="gvSelectedDateEvents" runat="server" Width="100%">
        </asp:GridView>
        <ECalendar:EventCalendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Silver"
            BorderWidth="1px" Font-Names="Verdana"
            Font-Size="9pt" ForeColor="Black" Height="500px"
            Width="100%" FirstDayOfWeek="Monday" NextMonthText="Next &gt;" PrevMonthText="&lt; Prev" SelectionMode="DayWeekMonth" ShowGridLines="True" NextPrevFormat="ShortMonth" 
            ShowDescriptionAsToolTip="True" BorderStyle="Solid" EventDateColumnName="" EventDescriptionColumnName="" EventHeaderColumnName="" OnSelectionChanged="Calendar1_SelectionChanged">
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TodayDayStyle BackColor="#CCCCCC" />
            <SelectorStyle BorderColor="#404040" BorderStyle="Solid" />
            <DayStyle HorizontalAlign="Left" VerticalAlign="Top" Wrap="True" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <NextPrevStyle Font-Size="8pt" ForeColor="#333333" Font-Bold="True" VerticalAlign="Bottom" />
            <DayHeaderStyle BorderWidth="1px" Font-Bold="True" Font-Size="8pt" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True"
                Font-Size="12pt" ForeColor="#333399" HorizontalAlign="Center" VerticalAlign="Middle" />
        </ECalendar:EventCalendar>
    
    </div>
    </form>
</body>
</html>
