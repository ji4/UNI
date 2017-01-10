using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MsgList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //導向發帖頁面
        HyperLink1.NavigateUrl = "SendMsg.aspx?categoryid=" + Request.QueryString["categoryid"];
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //抓取當前選擇的列
        GridViewRow row = GridView1.SelectedRow;
        //導向到發送文帖的頁面
        Response.Redirect("contentlist.aspx?filename=" + row.Cells[6].Text);
    }
}