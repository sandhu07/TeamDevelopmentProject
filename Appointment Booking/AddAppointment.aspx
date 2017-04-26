<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="AddAppointment.aspx.cs" Inherits="AddAppointment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 149px;
            left: 195px;
            z-index: 1;
            width: 65px;
            height: 27px;
        }
        .auto-style2 {
            position: absolute;
            top: 137px;
            left: 37px;
            z-index: 1;
        }
        .auto-style3 {
            width: 237px;
            height: 243px;
            position: absolute;
            top: 175px;
            left: 302px;
            z-index: 1;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        Date<asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style2"></asp:TextBox>
        <br />
    </p>
    <br />
    <asp:Button ID="Button1" runat="server" CssClass="auto-style1" OnClick="Button1_Click" Text="Button" />
    <br />
    <br />
    <asp:Calendar ID="Calendar1" runat="server" ClientIDMode="Static" ClientObjectName="hc" CssClass="auto-style3" OnSelectionChanged="Calendar1_SelectionChanged" OnCommand="Calendar1_OnCommand" OnBeforeEventRender="Calendar1_OnBeforeEventRender" EventClickHandling="JavaScript" EventClickJavaScript="edit(e)" Visible="False" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="250px" NextPrevFormat="ShortMonth" Width="330px" DayNameFormat="Full">
        <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
        <DayStyle BackColor="#CCCCCC" />
        <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
        <OtherMonthDayStyle ForeColor="#999999" />
        <SelectedDayStyle BackColor="#333399" ForeColor="White" />
        <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
        <TodayDayStyle BackColor="#999999" ForeColor="White" />
    </asp:Calendar>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />

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

