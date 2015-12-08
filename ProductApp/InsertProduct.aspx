<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertProduct.aspx.cs" Inherits="ProductApp.InsertProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <fieldset>
            <legend>Add Products</legend>
        
    <table runat="server">
        <tr>
            <th>
                <asp:Label ID="Label1" runat="server" Text="Brand Name"></asp:Label>
            </th>
            <td>
                <asp:TextBox ID="txtBrandName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <th>
                <asp:Label ID="Label2" runat="server" Text="Catagory"></asp:Label>
            </th>
            <td>
                <asp:TextBox ID="txtCatagory" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <th>
                <asp:Label ID="Label3" runat="server" Text="Details"></asp:Label>
            </th>
            <td>
                <asp:TextBox ID="txtDetails" TextMode="MultiLine" runat="server" Width="128px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <th>
                <asp:Label ID="Label4" runat="server" Text="Price"></asp:Label>
            </th>
            <td>
                <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <th>
                <asp:Label ID="Label5" runat="server" Text="Stock"></asp:Label>
            </th>
            <td>
                <asp:TextBox ID="txtStock" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <th>
                <asp:Label ID="Label6" runat="server" Text="No Of Iteam"></asp:Label>
            </th>
            <td>
                <asp:TextBox ID="txtNoOfIteam" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <th>
                <asp:Label ID="Label7" runat="server" Text="Product Type"></asp:Label>
            </th>
            <td>
                <asp:TextBox ID="txtProductType" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" Width="128px" />
            </td>
        </tr>
    </table>
            <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
            
            
            <asp:GridView ID="productGridView" runat="server"></asp:GridView>
            </fieldset>
    </div>
    </form>
</body>
</html>
