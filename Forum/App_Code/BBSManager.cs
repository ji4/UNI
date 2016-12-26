using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.IO;
using System.Xml;

/// <summary>
/// BBSManager 的摘要描述
/// </summary>
public class BBSManager
{
    public BBSManager()
    {
        //
        // TODO: 在這裡新增建構函式邏輯
        //
    }
    private string xmlfilename = "";
    public void AddXML(string filename, string title, string content, string user)
    {
        //載入XML檔案
        XElement myxml = XElement.Load(filename);
        //建立新的XML元素, LINQ可一次產生元素的所有內容
        XElement newxml = new XElement("xmlrecord",
            new XElement("title", title),
            new XElement("posttime", DateTime.Now.Date),
            new XElement("content", content),
            new XElement("postuser"), user);

        //添加新元素到XML中
        myxml.Add(newxml);

        //抓取文件路徑
        int index = filename.LastIndexOf(@"\");
        string path = filename.Substring(0, index);
        //新檔案名稱
        path = path + @"\" + xmlfilename + "file.xml";
        //建立文件後必須關閉, 否則其他程式無法使用
        FileStream mystream = File.Create(path);
        mystream.Close();

        //儲存所有異動到指定檔案, 注意編碼的方式
        XmlWriterSettings settings = new XmlWriterSettings();
        settings.Encoding = System.Text.Encoding.Default;
        XmlWriter myw = XmlWriter.Create(path);
        //儲存文件
        myxml.Save(myw);
        myw.Close();
    }

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

    private int getFilename()
    {
        //建立資料內文物件
        DataClassesDataContext db = new DataClassesDataContext();
        //選擇最大的ID
        var count = (from p in db.BBSInfo
                     orderby p.InfoID descending
                     select p.InfoID).First();
        //返回ID+1
        return count + 1;
    }

    public bool UpdateMsg(int infoid)
    {
        //建立資料內文物件
        DataClassesDataContext db = new DataClassesDataContext();
        //抓取符合條件的記錄
        BBSInfo info = db.BBSInfo.First(p => p.InfoID == infoid);
        //回覆數加1
        info.ReplyCount += 1;
        //修改回覆日期
        info.LastReplytime = DateTime.Now.Date;
        //提交更改
        db.SubmitChanges();
        return true;
    }
}