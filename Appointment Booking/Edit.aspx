<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Edit.aspx.cs" Inherits="Edit" %>
<!DOCTYPE html PUBLIC "" "">
<html xmlns="" >
<head runat="server">
    <title>Doctor Edit</title>
    <link href='Stylesheet/manvir-stylesheet2.css' type="text/css" rel="stylesheet" /> 
    <script src="Scripts/jquery-1.9.1.js"></script>
    <style type="text/css">
        .auto-style1 {
            width: 397px;
            height: 205px;
        }
        .auto-style2 {
            height: 51px;
        }
        .auto-style3 {
            height: 46px;
        }
        .auto-style4 {
            height: 39px;
        }
        .auto-style5 {
            height: 45px;
        }
        .auto-style6 {
            height: 7px;
        }
        .auto-style7 {
            height: 44px;
        }
        .auto-style8 {
            height: 49px;
        }
    </style>
</head>
<body class="dialog" style="width: 454px; height: 391px">
    <form id="form1" runat="server">
    <div>
        <table border="0" cellspacing="4" cellpadding="0" class="auto-style1">
            <tr>
                <td align="right" class="auto-style2"></td>
                <td class="auto-style2">
                    <div class="header">Edit Time Slot</div>
                    <asp:LinkButton ID="LinkButtonDelete" runat="server" OnClick="LinkButtonDelete_Click">Delete</asp:LinkButton>
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td align="right" class="auto-style3">Start Time:</td>
                <td class="auto-style3"><asp:TextBox ID="txtStart" runat="server" Width="200px" Enabled="false"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right" class="auto-style4">End Time:</td>
                <td class="auto-style4"><asp:TextBox ID="txtEnd" runat="server" Width="200px" Enabled="false"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right" class="auto-style5">Doctor Name:</td>
                <td class="auto-style5"><asp:DropDownList ID="ddlDoctor" runat="server" Width="200px" OnSelectedIndexChanged="ddlDoctor_SelectedIndexChanged"></asp:DropDownList></td>
            </tr>
            <tr>
                <td align="right" class="auto-style6">Booking Status:</td>
                <td class="auto-style6"><asp:DropDownList ID="ddlStatus" runat="server" >
                        <asp:ListItem Value="free">Available</asp:ListItem>
                        <asp:ListItem Value="confirmed">Confirm Booking</asp:ListItem>
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td align="right" class="auto-style7">Patient Name:</td>
                <td class="auto-style7"><asp:TextBox ID="txtName" runat="server" Width="200px"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right" class="auto-style8"></td>
                <td class="auto-style8">
                    <asp:Button ID="btnOK" runat="server" OnClick="ButtonOK_Click" Text="  OK  " />
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="ButtonCancel_Click" />
                    <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete Booking" />
                </td>
            </tr>
        </table>
        
        </div>
    </form>
    <script>
        $(document).ready(function() {
            $("#DropDownListStatus").change(function() {
                var status = $(this).val();
                var disabled = status === "free";
                $("#TextBoxName").prop("disabled", disabled);
                if (disabled) {
                    $("#TextBoxName").val("");
                }
            });
            $("#DropDownListStatus").change();
        });
    </script>
</body>
</html>
