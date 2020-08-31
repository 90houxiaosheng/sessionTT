<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CratWeb.aspx.cs" Inherits="WebApplication1.CratWeb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
<form id="form1" runat="server">
    <div>
        <asp:CheckBox ID="CheckBox1" runat="server" Text="瓜子" /> <br />
        <asp:CheckBox ID="CheckBox2" runat="server" Text="花生" /><br />
        <asp:CheckBox ID="CheckBox3" runat="server" Text="辣条" /><br />
        <asp:CheckBox ID="CheckBox4" runat="server" Text="天然狗粮，单身狗吃了毛色好" /><br />
        <asp:CheckBox ID="CheckBox5" runat="server" Text="水果" />&nbsp;<br />
        <asp:Button ID="btnAddTocart" runat="server" Text="将所选商品添加到购物车" OnClick="btnAddTocart_Click" Width="268px" />
        &nbsp;
        <asp:Button ID="btnShowcart" runat="server" Text="显示商品" OnClick="btnShowcart_Click" />
    
        &nbsp;<asp:Button ID="btnExit" runat="server" Text="退出登录 " OnClick="btnExit_Click"  />

        <br />
        <asp:Literal ID="ItaMsg" runat="server"></asp:Literal>

    </div>
    </form>
</body>
</html>
