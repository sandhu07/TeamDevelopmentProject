<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Request.aspx.cs" Inherits="Request" %>
<!DOCTYPE html PUBLIC "" "">
<html>
<head runat="server">
    <title>New event</title>
    <link href='Stylesheet/manvir-stylesheet2.css' type="text/css" rel="stylesheet" /> 
    <script src="Scripts/jquery-1.9.1.js"></script>
    <style type="text/css">
        .auto-style1 {
            height: 93px;
        }
        .auto-style2 {
            height: 41px;
        }
        .auto-style3 {
            height: 55px;
        }
        .auto-style4 {
            height: 60px;
        }
    </style>
</head>
<body class="dialog" style="height: 253px; width: 348px;">
    <form id="form1" runat="server">
    <div>
        <table border="0" cellspacing="4" cellpadding="0" class="auto-style1">
            <tr>
                <td align="right" class="auto-style2"></td>
                <td class="auto-style2">
                    <div class="header">Request an Appointment</div>
                </td>
            </tr>
            <tr>
                <td align="right" class="auto-style2">Start:</td>
                <td class="auto-style2"><asp:TextBox ID="TextBoxStart" runat="server" Width="200px" Enabled="false"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right" class="auto-style2">End:</td>
                <td class="auto-style2"><asp:TextBox ID="TextBoxEnd" runat="server" Width="200px" Enabled="false"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right" class="auto-style3">Your Name:</td>
                <td class="auto-style3"><asp:TextBox ID="TextBoxName" runat="server" Width="200px"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right" class="auto-style4">Doctor:</td>
                <td class="auto-style4">
                    <asp:DropDownList ID="ddlDoctor" runat="server" Width="200px"></asp:DropDownList>
                </td>
            </tr>
        </table>
        
        <table border="0" cellspacing="4" cellpadding="0" class="auto-style1">
            <tr>
                <td align="right" class="auto-style4">
                    <asp:Button ID="ButtonOK" runat="server" OnClick="ButtonOK_Click" Text="  OK  " Height="36px" />
                    <asp:Button ID="ButtonCancel" runat="server" Text="Cancel" OnClick="ButtonCancel_Click" Height="36px" />
                </td>
            </tr>
        </table>
        
        </div>
    </form>
    <script>
        $(document).ready(function() {
            $("#TextBoxName").keyup(function() {
                var text = $(this).val();
                $("#CheckBoxScheduled").prop("checked", !!text);
            })
        });
    </script>
</body>
</html>
