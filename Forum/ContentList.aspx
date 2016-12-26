<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ContentList.aspx.cs" Inherits="ContentList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DataList ID="DataList1" runat="server" DataSourceID="XmlDataSource1" Width="465px">
        <HeaderTemplate><b>文帖詳細內容</b><table></HeaderTemplate>
            <ItemTemplate><tr><td>主題 : <b><%#XPath("title")%></b></td>
                    <td>發帖人 : <%#XPath("postuser")%></td></tr>
                <tr><td colspan="2">發帖時間 : <%#XPath("posttime")%>
                    </td></tr>
                <tr><td></td></tr>
                <tr><td colspan="2"><%#XPath("content")%></td></tr>
                <br />
            </ItemTemplate>
            <FooterTemplate></table></FooterTemplate>
        </asp:DataList>
        <asp:XmlDataSource ID="XmlDataSource1" runat="server"></asp:XmlDataSource>
    
    </div>
    </form>
</body>
</html>
