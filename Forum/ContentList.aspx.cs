using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ContentList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //設定DataList的資料原始檔案
        XmlDataSource1.DataFile = Request.QueryString["filename"] + "file.xml";
        HyperLink1.NavigateUrl = "backmsg.aspx?infoid" + Request.QueryString["filename"];
    }
}