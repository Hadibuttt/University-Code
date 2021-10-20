<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="supplier.aspx.cs" Inherits="WebA.supplier" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Supplier</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center style="text-decoration:underline;">Supplier Form</center>
            <asp:Label ID="NameLabel" runat="server" Text="Name"></asp:Label>&nbsp
            <asp:TextBox ID="name" runat="server"></asp:TextBox><br />
            
            <asp:Label ID="EmailLabel" runat="server" Text="Email"></asp:Label>&nbsp
            <asp:TextBox ID="email" runat="server"></asp:TextBox><br />
            
            <asp:Label ID="CnicLabel" runat="server" Text="CNIC"></asp:Label>&nbsp
            <asp:TextBox ID="cnic" runat="server"></asp:TextBox><br />

            <asp:Label ID="AddressLabel" runat="server" Text="Address"></asp:Label>&nbsp
            <asp:TextBox ID="address" runat="server"></asp:TextBox><br />
            
            <asp:Label ID="PhoneLabel" runat="server" Text="Phone"></asp:Label>&nbsp
            <asp:TextBox ID="phone" runat="server"></asp:TextBox><br />

            <br /><asp:Label ID="msg" runat="server" Text=""></asp:Label><br />

            <br />
            <asp:Button ID="create" runat="server" Text="Create" OnClick="create_Click" />
            <asp:Button ID="update" runat="server" Text="Update" OnClick="update_Click" />
            <asp:Button ID="delete" runat="server" Text="Delete" OnClick="delete_Click" />
            <asp:Button ID="select" runat="server" Text="Select" OnClick="select_Click" />
            <asp:Button ID="clear" runat="server" Text="Clear" OnClick="clear_Click" />

            &nbsp<asp:GridView ID="sGrid" runat="server"></asp:GridView>


        </div>
    </form>
</body>
</html>
