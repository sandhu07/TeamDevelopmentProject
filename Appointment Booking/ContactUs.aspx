<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="ContactUs.aspx.cs" Inherits="ContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
        <h3>Contact Us By Email</h3>
    <p>
    &nbsp;<br />
    </p>
    <br />
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 124px; top: 295px; position: absolute; height: 111px; width: 406px"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 28px; top: 329px; position: absolute" Text="Your Message"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 129px; top: 256px; position: absolute; width: 262px"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 129px; top: 216px; position: absolute; width: 266px"></asp:TextBox>
    <br />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 46px; top: 221px; position: absolute" Text="Your Name"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 46px; top: 260px; position: absolute" Text="Your Email"></asp:Label>
        <br />
        <br />
        <br />
    <br />
    <br />
    <br />
    <br />
    <br />
        <br />
        <asp:Button ID="btnMessage" runat="server" style="z-index: 1; left: 176px; top: 418px; position: absolute" Text="Send Us Your Message" OnClick="btnMessage_Click" />
        <br />
        <br />
        <br />
        <br />
    <br />
</asp:Content>

