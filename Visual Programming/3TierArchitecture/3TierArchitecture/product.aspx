<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="product.aspx.cs" Inherits="_3TierArchitecture.product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product</title>
</head>
<body>
    <center>Product Form</center>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td><asp:Label ID="NameLabel" runat="server" Text="Name:"></asp:Label></td>
                <td class="auto-style1"><asp:TextBox ID="name" runat="server"></asp:TextBox></td>
            </tr>

            <tr>
                <td><asp:Label ID="PriceLabel" runat="server" Text="Price"></asp:Label></td>
                <td class="auto-style1"><asp:TextBox ID="price" runat="server"></asp:TextBox></td>
            </tr>
            
            <tr>
                <td><asp:Label ID="CategoryLabel" runat="server" Text="Category"></asp:Label></td>
                <td class="auto-style1"><asp:TextBox ID="category" runat="server"></asp:TextBox></td>
            </tr>
            
            <tr>
                <td><asp:Label ID="DescriptionLabel" runat="server" Text="Description"></asp:Label></td>
                <td class="auto-style1"><asp:TextBox ID="description" runat="server"></asp:TextBox></td>
            </tr>

            <tr>
                <td><asp:Label ID="VendorLabel" runat="server" Text="Vendor"></asp:Label></td>
                <td class="auto-style1"><asp:TextBox ID="vendor" runat="server"></asp:TextBox></td>
            </tr>

            <tr>
                <td><asp:Label ID="StockLabel" runat="server" Text="Stock"></asp:Label></td>
                <td class="auto-style1"><asp:TextBox ID="stock" runat="server"></asp:TextBox></td>
            </tr>

            <tr>
                <td><asp:Label ID="StatusLabel" runat="server" Text="Status"></asp:Label></td>
                <td class="auto-style1"><asp:TextBox ID="status" runat="server"></asp:TextBox></td> 
            </tr>
            
            <tr>
                <td><asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label></td>
            </tr>

            <tr>
                <td>
                    <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />&nbsp
                    <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />&nbsp
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />&nbsp
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />&nbsp
                    <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />&nbsp
                </td>
            </tr>
        </table>
        <asp:GridView ID="pGrid" runat="server" Width="693px"></asp:GridView>    
    </form>
</body>
</html>
