<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BackMsg.aspx.cs" Inherits="BackMsg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="回覆主題"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Width="267px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="回覆內容"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" Height="146px" style="margin-top: 0px" Width="266px"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="必須填寫內容"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="回覆" Width="99px" OnClick="Button1_Click" />
    &nbsp;&nbsp;&nbsp;
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    </div>
    </form>
</body>
</html>
