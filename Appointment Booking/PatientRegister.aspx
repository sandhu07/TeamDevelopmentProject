<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="PatientRegister.aspx.cs" Inherits="PatientRegister" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .auto-style9 {
            z-index: 1;
            left: 419px;
            top: 443px;
            position: absolute;
            width: 111px;
            height: 32px;
        }
        .auto-style11 {
            z-index: 1;
            left: 149px;
            top: 238px;
            position: absolute;
        }
        .auto-style12 {
            z-index: 1;
            left: 66px;
            top: 243px;
            position: absolute;
        }
        .auto-style13 {
            z-index: 1;
            left: 60px;
            top: 206px;
            position: absolute;
        }
        .auto-style14 {
            z-index: 1;
            left: 44px;
            top: 287px;
            position: absolute;
        }
        .auto-style15 {
            z-index: 1;
            left: 510px;
            top: 348px;
            position: absolute;
        }
        .auto-style16 {
            z-index: 1;
            left: 93px;
            top: 328px;
            position: absolute;
            width: 39px;
        }
        .auto-style17 {
            z-index: 1;
            left: 148px;
            top: 360px;
            position: absolute;
            margin-top: 8px;
        }
        .auto-style18 {
            z-index: 1;
            left: 49px;
            top: 368px;
            position: absolute;
        }
        .auto-style19 {
            z-index: 1;
            left: 148px;
            top: 326px;
            position: absolute;
        }
        .auto-style20 {
            z-index: 1;
            left: 596px;
            top: 203px;
            position: absolute;
            width: 145px;
        }
        .auto-style23 {
            z-index: 1;
            left: 555px;
            top: 457px;
            position: absolute;
            width: 197px;
        }
        .auto-style24 {
            z-index: 1;
            left: 508px;
            top: 384px;
            position: absolute;
            width: 78px;
        }
        .auto-style25 {
            z-index: 1;
            left: 460px;
            top: 413px;
            position: absolute;
            width: 115px;
        }
        .auto-style26 {
            z-index: 1;
            left: 600px;
            top: 379px;
            position: absolute;
            width: 140px;
        }
        .auto-style28 {
            z-index: 1;
            left: 491px;
            top: 309px;
            position: absolute;
            height: 18px;
            width: 87px;
        }
        #Password1 {
            z-index: 1;
            left: 790px;
            top: 377px;
            position: absolute;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
                <h3>&nbsp;Register Your Details</h3>
<p>
    <asp:Label ID="lblDOB" runat="server" Text="DOB" CssClass="auto-style16"></asp:Label>
    <asp:Label ID="lblError" runat="server" CssClass="auto-style23"></asp:Label>
    <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" CssClass="auto-style9" />
    <asp:Label ID="lblSurname" runat="server" Text="Surname" CssClass="auto-style12"></asp:Label>
    <asp:Label ID="lblFirstName" runat="server" Text="First Name" CssClass="auto-style13"></asp:Label>
    <asp:Label ID="lblHomeAddress" runat="server" CssClass="auto-style18">Home Address</asp:Label>
    <asp:Label ID="lblPersonalEmailAddress" runat="server" Text="Email Address" CssClass="auto-style14"></asp:Label>
    <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 148px; top: 200px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 147px; top: 283px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtHomeAddress" runat="server" CssClass="auto-style17"></asp:TextBox>
    <asp:TextBox ID="txtSurname" runat="server" CssClass="auto-style11"></asp:TextBox>
    <asp:TextBox ID="txtDOB" runat="server" CssClass="auto-style19"></asp:TextBox>
    <asp:TextBox ID="txtMedication" runat="server" CssClass="auto-style20"></asp:TextBox>
    <asp:Label ID="lblUserNo" runat="server" Text="UserName" CssClass="auto-style15"></asp:Label>
    <asp:Label ID="lblUsername" runat="server" Text="Last Visit GP:" CssClass="auto-style28"></asp:Label>
    <asp:Label ID="lblPassword" runat="server" Text="Password :" CssClass="auto-style24"></asp:Label>
    <asp:Label ID="lblConfirm" runat="server" Text="Confirm Password :" CssClass="auto-style25"></asp:Label>
    <asp:TextBox ID="txtPassword" runat="server" CssClass="auto-style26"></asp:TextBox>
    </p>
    <br />
                <asp:TextBox ID="txtTravelInsurance" runat="server" style="z-index: 1; left: 596px; top: 233px; position: absolute; width: 144px"></asp:TextBox>
    <br />
    <br />
                <asp:DropDownList ID="ddlGPName" runat="server" DataSourceID="SqlDataSource1" DataTextField="GPName" DataValueField="GPName" style="z-index: 1; left: 600px; top: 263px; position: absolute; height: 18px; width: 147px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:healthcare %>" SelectCommand="SELECT [GPName] FROM [tblGPCompany]"></asp:SqlDataSource>
    <br />
    <br />
                <asp:TextBox ID="txtGPVisit" runat="server" style="z-index: 1; left: 598px; top: 305px; position: absolute; width: 138px"></asp:TextBox>
    <br />
    <br />
    <br />
    <br />
    <br />
                <asp:Label ID="lblMedication" runat="server" style="z-index: 1; left: 424px; top: 209px; position: absolute" Text="Do you take Medication?"></asp:Label>
    <br />
    <br />
                <asp:Label ID="lblGPName" runat="server" style="z-index: 1; left: 476px; top: 273px; position: absolute" Text="Select GP Name"></asp:Label>
    <br />
    <asp:TextBox ID="txtConfirmPassword" runat="server" style="z-index: 1; left: 601px; top: 411px; position: absolute; width: 141px;"></asp:TextBox>
                <asp:Label ID="lblPostcode" runat="server" style="z-index: 1; left: 73px; top: 417px; position: absolute" Text="Postcode"></asp:Label>
                <asp:TextBox ID="txtPostcode" runat="server" style="z-index: 1; left: 149px; top: 413px; position: absolute"></asp:TextBox>
    <br />
    <asp:Button ID="btnRegister" runat="server" style="z-index: 1; left: 300px; top: 444px; position: absolute; height: 31px; width: 100px;" Text="Register" OnClick="btnRegister_Click1" />
                <asp:Label ID="lblTravelInsurance" runat="server" style="z-index: 1; left: 394px; top: 239px; position: absolute" Text="Do you have Travel Insurance?"></asp:Label>
    <br />
    <br />
    <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 600px; top: 344px; position: absolute; width: 135px;"></asp:TextBox>
                <br />
    <br />
</asp:Content>

