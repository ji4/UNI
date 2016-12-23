using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SendMsg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    /// <summary>
    /// 添加文帖資訊到資料庫
    /// </summary>
    /// <param name="title">主題</param>
    /// <param name="filename">檔案名稱</param>
    /// <param name=""replycount>回覆數</param>
    /// <param name="user"></param>
    /// <param name="categoryid">類別ID</param>
    

    protected void btnPublishArticle_Click(object sender, EventArgs e)
    {
        BBSManager mybbs = new BBSManager();
        //抓取當前用戶名稱
        string username = HttpContext.Current.User.Identity.Name;
        //添加訊息到資料庫
        mybbs.AddMsg(TextBox1.Text, username, int.Parse(Request.QueryString["categoryid"]));
        //詳細內容加到XML
        mybbs.AddXML(Server.MapPath(",")+@"\content.xml",
            TextBox1.Text, TextBox2.Text, username);
        Literal1.Text = "文帖發布成功!";
       
    }
}