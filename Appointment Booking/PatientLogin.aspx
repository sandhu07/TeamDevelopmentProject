<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="PatientLogin.aspx.cs" Inherits="PatientLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 340px;
            top: 176px;
            position: absolute;
            width: 307px;
            height: 96px;
        }
        .auto-style2 {
            position: absolute;
            top: 282px;
            left: 81px;
            z-index: 1;
            width: 125px;
            height: 38px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
           <h3>&nbsp;Login Page</h3>
        <asp:Label ID="lblUsername" runat="server" Text="Username" CssClass="auto-style14"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" CssClass="auto-style11" Height="35px" Width="166px"></asp:TextBox>
    <br />
    <br />
        <asp:Label ID="lblPassword" runat="server" Text="Password" CssClass="auto-style13"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" CssClass="auto-style15" Height="33px" Width="168px" TextMode="Password"></asp:TextBox>
        <br />
    <br />
           <asp:Button ID="btnLogin" runat="server" CssClass="auto-style2" OnClick="btnLogin_Click" Text="Login" />
           <br />
           <br />
    <br />
    <br />
        <asp:Button ID="btnRegister" runat="server" CssClass="auto-style18" style="top: 328px; left: 179px" Text="Register" OnClick="btnRegister_Click" />
        <asp:Button ID="btnPassword" runat="server" OnClick="btnPassword_Click" Text="Forgot Password" CssClass="auto-style18" />
        <br />
    <br />
    <br />
            <asp:Label ID="lblError" runat="server" Text="lblError" CssClass="auto-style1"></asp:Label>
    <br />
    <br />
    <br />
</asp:Content>

