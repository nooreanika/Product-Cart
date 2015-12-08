<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WalletAndCartOperation.aspx.cs" Inherits="ProductApp.WalletAndCartOperation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table runat="server">
        <tr>
            <th>Product Catagory</th>
            <td>
                <asp:DropDownList ID="catagoryDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="catagoryDropDownList_SelectedIndexChanged"></asp:DropDownList></td>
        </tr>
        <tr>
            <th>Product Type</th>
            <td>
                <asp:DropDownList ID="productTypeDropDownList" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click" Width="73px" /></td>
        </tr>
    </table>
        
        <asp:GridView ID="showGridView" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
