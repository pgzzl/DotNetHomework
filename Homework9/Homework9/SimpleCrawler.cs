using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Homework9 {
  class SimpleCrawler {
     public static string strDisplay { get; set; }
     public string newDisplay;
    private Hashtable urls = new Hashtable();
    private int count = 0;
        
    public string Begin(string strURL) {
            newDisplay = "1";
            strDisplay = "say something";
         
      SimpleCrawler myCrawler = new SimpleCrawler();
      //string startUrl = "http://www.cnblogs.com/dstang2000/";
     // if (args.Length >= 1) strURL = args[0];
      myCrawler.urls.Add(strURL, false);//加入初始页面
            Thread myThread = new Thread(myCrawler.Crawl);
            myThread.Start();
            myThread.Join();
            if (!myThread.IsAlive)
            {
                Console.WriteLine("现在的传回值为:"+strDisplay);
                Console.WriteLine("现在的传回值为:" + newDisplay);
                Console.WriteLine("现在的hash为:" + urls.Count);
                return strDisplay;
            }
            else
                return "nothing";
        }

    public void Crawl() {
            //this.strDisplay="开始爬行了.... ";
            Console.WriteLine("开始爬行了");
      while (true) {
        string current = null;
        foreach (string url in urls.Keys) {
                    if ((bool)urls[url]&&!Regex.IsMatch(url,"html|aspx|jsp"))
                    { 
                        continue;
                    }
          current = url;
        }
        
        if (current == null || count > 10) break;
                
                    //this.strDisplay += "爬行";
                    //this.strDisplay += current;
                    //this.strDisplay+="页面!";
                    Console.WriteLine("爬行" + current + "页面！");
                    strDisplay += current + "\n";
                newDisplay += current + "\n";
                
        string html = DownLoad(current); // 下载
        urls[current] = true;
        count++;
        Parse(html,current);//解析,并加入新的链接
                    //this.strDisplay+="爬行结束";
                
      }
            Console.WriteLine("爬行结束str:"+strDisplay);
        }

    public string DownLoad(string url) {
      try {
        WebClient webClient = new WebClient();
        webClient.Encoding = Encoding.UTF8;
        string html = webClient.DownloadString(url);
        string fileName = count.ToString();
        File.WriteAllText(fileName, html, Encoding.UTF8);
        return html;
      }
      catch (Exception ex) {
        Console.WriteLine(ex.Message);
        return "";
      }
    }

    public void Parse(string html,string current) {
      string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
      MatchCollection matches = new Regex(strRef).Matches(html);
      foreach (Match match in matches) {
        strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                  .Trim('"', '\"', '#', '>');
                if (Regex.IsMatch(strRef, @"^[.]{1}/[\w]+[/]?"))
                {
                    strRef = current + strRef.Substring(1);
                }
                if (Regex.IsMatch(strRef, @"^/[\w]+[/]?"))
                {
                    string root = new Regex(@"^https?://[\w]+.cnblogs.com").Match(current ).Value;
                    strRef = root + strRef;

                }
                if (Regex.IsMatch(strRef, @"^[.]{2}/[\w]+[/]?"))
                {
                    var index = current.LastIndexOf('/');
                    var root = current.Substring(0, index + 1);
                    strRef = strRef.Substring(3);
                    strRef = strRef + root;
                }
                if (strRef.Length == 0) continue;
        if (urls[strRef] == null) urls[strRef] = false;
      }
    }
  }
}
