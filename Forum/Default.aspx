<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MsgList.aspx.cs" Inherits="MsgList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" DataSourceID="LinqDataSource1" AutoGenerateColumns="False" DataKeyNames="InfoID" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="InfoID" HeaderText="InfoID" SortExpression="InfoID" ReadOnly="True" />
                <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                <asp:BoundField DataField="FileName" HeaderText="FileName" SortExpression="FileName" />
                <asp:BoundField DataField="PostTime" HeaderText="PostTime" SortExpression="PostTime" />
                <asp:BoundField DataField="ReplyCount" HeaderText="ReplyCount" SortExpression="ReplyCount" />
                <asp:BoundField DataField="LastReplytime" HeaderText="LastReplytime" SortExpression="LastReplytime" />
                <asp:BoundField DataField="PostUser" HeaderText="PostUser" SortExpression="PostUser" />
                <asp:BoundField DataField="CategoryID" HeaderText="CategoryID" SortExpression="CategoryID" />
            </Columns>
        </asp:GridView>
    
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="DataClassesDataContext" EntityTypeName="" TableName="BBSInfo" Where="CategoryID == @CategoryID">
            <WhereParameters>
                <asp:QueryStringParameter Name="CategoryID" QueryStringField="categoryid" Type="Int32" />
            </WhereParameters>
        </asp:LinqDataSource>
    
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
