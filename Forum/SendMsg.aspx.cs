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
    public void AddMsg(string title, string user, int categoryid)
    {
        //建立資料內文物件
        DataClassesDataContext db = new DataClassesDataContext();
        //建立新的論壇物件
        BBSInfo myinfo = new BBSInfo
        {
            Title = title,
            FileName = getFilename().ToString(),
            PostTime = DateTime.Now.Date,
            ReplyCount = 0,
            LastReplytime = DateTime.Now.Date,
            PostUser = user,
            CategoryID = categoryid

        };
        xmlfilename = myinfo.FileName;
        //添加論壇物件到資料內文
        db.BBSInfo.InsertOnSubmit((myinfo));
        //提交易動
        db.SubmitChanges();

    }
}