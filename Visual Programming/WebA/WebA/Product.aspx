<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="WebA.Product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product Form</title>
</head>
<body>
    <form id="product" runat="server">
        <div>
            <center style="text-decoration:underline;">Product</center>
            <asp:Label ID="NameLabel" runat="server" Text="Name"></asp:Label>&nbsp
            <asp:TextBox ID="name" runat="server"></asp:TextBox><br />
            
            <asp:Label ID="DescLabel" runat="server" Text="Description"></asp:Label>&nbsp
            <asp:TextBox ID="description" runat="server"></asp:TextBox><br />
            
            <asp:Label ID="PriceLabel" runat="server" Text="Price"></asp:Label>&nbsp
            <asp:TextBox ID="price" runat="server"></asp:TextBox><br />

            <asp:Label ID="CategoryLabel" runat="server" Text="Category"></asp:Label>&nbsp
            <asp:TextBox ID="category" runat="server"></asp:TextBox><br />
            
            <asp:Label ID="StockLabel" runat="server" Text="Stock"></asp:Label>&nbsp
            <asp:TextBox ID="stock" runat="server"></asp:TextBox><br />

            <asp:Label ID="VendorLabel" runat="server" Text="Vendor"></asp:Label>&nbsp
            <asp:TextBox ID="vendor" runat="server"></asp:TextBox><br />

            <asp:Label ID="StatusLabel" runat="server" Text="Status"></asp:Label>&nbsp
            <asp:TextBox ID="status" runat="server"></asp:TextBox><br />

            
            <br /><asp:Label ID="msg" runat="server" Text=""></asp:Label><br />

            <br />
            <asp:Button ID="create" runat="server" Text="Create" OnClick="create_Click" />
            <asp:Button ID="update" runat="server" Text="Update" OnClick="update_Click" />
            <asp:Button ID="delete" runat="server" Text="Delete" OnClick="delete_Click" />
            <asp:Button ID="select" runat="server" Text="Select" OnClick="select_Click" />
            <asp:Button ID="clear" runat="server" Text="Clear" OnClick="clear_Click" />

            &nbsp<asp:GridView ID="pGrid" runat="server"></asp:GridView>


        </div>
    </form>
</body>
</html>
