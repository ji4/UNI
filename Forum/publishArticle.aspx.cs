using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.IO;
using System.Xml;

public partial class publishArticle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
     
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
}