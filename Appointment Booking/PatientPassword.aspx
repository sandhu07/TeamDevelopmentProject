<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="PatientPassword.aspx.cs" Inherits="PatientPassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 115px;
            top: 341px;
            position: absolute;
            height: 42px;
            width: 176px;
        }
        .auto-style2 {
            z-index: 1;
            left: 163px;
            top: 291px;
            position: absolute;
            width: 185px;
            height: 26px;
        }
        .auto-style3 {
            z-index: 1;
            left: 38px;
            top: 297px;
            position: absolute;
        }
        .auto-style4 {
            position: absolute;
            top: 250px;
            left: 372px;
            z-index: 1;
            width: 115px;
            height: 69px;
        }
        .auto-style5 {
            position: absolute;
            top: 341px;
            left: 312px;
            z-index: 1;
            width: 152px;
            height: 42px;
        }
        .auto-style6 {
            position: absolute;
            top: 411px;
            left: 159px;
            z-index: 1;
            width: 187px;
            height: 18px;
            right: 746px;
        }
        .auto-style7 {
            position: absolute;
            top: 195px;
            left: 165px;
            z-index: 1;
            width: 179px;
            height: 31px;
        }
        .auto-style8 {
            position: absolute;
            top: 207px;
            left: 59px;
            z-index: 1;
        }
        .auto-style9 {
            z-index: 1;
            left: 54px;
            top: 250px;
            position: absolute;
        }
        .auto-style10 {
            z-index: 1;
            left: 162px;
            top: 246px;
            position: absolute;
            width: 185px;
            height: 24px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
        <h3>Reset your Password<asp:Button ID="btnBack" runat="server" CssClass="auto-style5" OnClick="btnBack_Click" Text="Back to Login" />
        </h3>
        <asp:TextBox ID="txtNewPassword" runat="server" CssClass="auto-style2"></asp:TextBox>
        <br />
        <asp:Label ID="lblEmail" runat="server" CssClass="auto-style8" Text="Email Address:"></asp:Label>
        <br />
        <asp:Label ID="lblConfirmPassword" runat="server" Text="Confirm Password:" CssClass="auto-style3"></asp:Label>
        <br />
        <asp:TextBox ID="txtPassword" runat="server" CssClass="auto-style10"></asp:TextBox>
        <br />
        <asp:Label ID="lblPassword" runat="server" Text="New Password:" CssClass="auto-style9"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" CssClass="auto-style7"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style6" Text="lblError"></asp:Label>
        <br />
        <asp:Button ID="btnPassword" runat="server" CssClass="auto-style4" OnClick="btnPassword_Click" Text="Send Password" />
        <br />
        <asp:Button ID="btnNewPassword" runat="server" Text="Confirm New Password" OnClick="btnNewPassword_Click" CssClass="auto-style1" />
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
</asp:Content>

