<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RoleSession.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <center style="text-decoration:underline;">Login</center>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td><asp:Label ID="EmailLabel" runat="server" Text="Email"></asp:Label></td>
                <td class="auto-style1"><asp:TextBox ID="email" runat="server"></asp:TextBox></td>
            </tr>
            
            <tr>
                <td><asp:Label ID="PasswordLabel" runat="server" Text="Password"></asp:Label></td>
                <td class="auto-style1"><asp:TextBox ID="password" runat="server"></asp:TextBox></td>
            </tr>

            <tr>
                <td><asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label></td>
            </tr>

            <tr>
                <td>
                    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"/>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>