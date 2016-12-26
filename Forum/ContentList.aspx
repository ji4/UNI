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
    
        <asp:DataList ID="DataList1" runat="server" DataSourceID="XmlDataSource1">
        </asp:DataList>
        <asp:XmlDataSource ID="XmlDataSource1" runat="server"></asp:XmlDataSource>
    
    </div>
    </form>
</body>
</html>
