using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BackMsg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //初始化論壇操作類別
        BBSManager mybbs = new BBSManager();
        //呼叫儲存內容到XML中的方法
        string filename = Server.MapPath(".") + @"\" + Request.QueryString["infoid"] + "file.xml";
        mybbs.UpdateXML(filename, TextBox1.Text, TextBox2.Text, HttpContext.Current.User.Identity.Name);
        //更新資料庫的時間和次數資訊
        mybbs.UpdateMsg(int.Parse(Request.QueryString["infoid"]));
        Literal1.Text = "更新成功!";
        //導向到顯示頁面
        Response.Redirect("contentlist.aspx?filename=" + Request.QueryString["infoid"]);

    }
}