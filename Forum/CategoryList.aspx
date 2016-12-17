<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CategoryList.aspx.cs" Inherits="CategoryList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="LinqDataSource1">
            <HeaderTemplate>
                <table border="0">
            </HeaderTemplate>
            <ItemTemplate>
                <tr><td><a href="MsgList.aspx?categoryid=<%# Eval("categoryid") %>"><%# Eval("categoryname") %></a></td></tr>
                <tr><td><%#Eval("categorydes") %></td></tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" EntityTypeName="" ContextTypeName="DataClassesDataContext" TableName="BBSCategory">
        </asp:LinqDataSource>
    
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
