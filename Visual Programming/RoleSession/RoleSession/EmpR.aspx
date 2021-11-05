<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmpR.aspx.cs" Inherits="RoleSession.EmpR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <center style="text-decoration:underline;">Employee Registration Form</center>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td><asp:Label ID="NameLabel" runat="server" Text="Name:"></asp:Label></td>
                <td class="auto-style1"><asp:TextBox ID="name" runat="server"></asp:TextBox></td>
            </tr>

            <tr>
                <td><asp:Label ID="EmailLabel" runat="server" Text="Email"></asp:Label></td>
                <td class="auto-style1"><asp:TextBox ID="email" runat="server"></asp:TextBox></td>
            </tr>
            
            <tr>
                <td><asp:Label ID="PasswordLabel" runat="server" Text="Password"></asp:Label></td>
                <td class="auto-style1"><asp:TextBox ID="password" runat="server"></asp:TextBox></td>
            </tr>
            
            <tr>
                <td><asp:Label ID="CnicLabel" runat="server" Text="CNIC"></asp:Label></td>
                <td class="auto-style1"><asp:TextBox ID="cnic" runat="server"></asp:TextBox></td>
            </tr>

            <tr>
                <td><asp:Label ID="GenderLabel" runat="server" Text="Gender"></asp:Label></td>
                <td class="auto-style1"><asp:TextBox ID="gender" runat="server"></asp:TextBox></td>
            </tr>

            <tr>
                <td><asp:Label ID="AgeLabel" runat="server" Text="Age"></asp:Label></td>
                <td class="auto-style1"><asp:TextBox ID="age" runat="server"></asp:TextBox></td>
            </tr>

            <tr>
                <td><asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label></td>
            </tr>

            <tr>
                <td>
                    <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
