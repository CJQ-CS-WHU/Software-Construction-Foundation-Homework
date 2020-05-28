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

/*
 9讲
改进书上例子9-10的爬虫程序。
（1）只爬取起始网站上的网页（正则：在中间加上起始字符串,也不能一概而论，如果出现的是一个相对地址，那么就不能要求它拥有前缀。
        因此，要先判断它是否是绝对地址，如果是相对地址就变化为绝对地址，再对它进行判断）
（2）只有当爬取的是html文本时，才解析并爬取下一级URL（正则：在尾部加上html约束）√
（3）相对地址转成绝对地址进行爬取（加工）
（4）尝试使用Winform来配置初始URL，启动爬虫，显示已经爬取的URL和错误的URL信息。（窗体）

（1）判断前缀是否为起始网址相关的，如果是爬取之
    在parse函数中增加一个修改strRef,改成合成字符串
（2）判断后缀是否为html相关的，如果是则爬取下一级
（2）判断目标是否是相对地址，如果是则转化为绝对地址
（3）在winform窗体上input获取到一个地址，表单绑定url和result
*/
namespace HW9_CrawlWinform
{
    public class SimpleCrawler
    {
        //避免重复存储
        public Hashtable urls = new Hashtable();
        public string startUrl = "http://www.cnblogs.com/dstang2000/";
        public string state = "";
        private int count = 0;
        private string domain;
        /*
        static void Main(string[] args)
        {
            SimpleCrawler myCrawler = new SimpleCrawler();
            //初始URL
            string startUrl = "";
            //获取到域名地址
            myCrawler.domain = myCrawler.GetDomainName(startUrl);
            //可以读取
            if (args.Length >= 1) startUrl = args[0];
            myCrawler.urls.Add(startUrl, false);//加入初始页面
            
        }
        */
        //总爬取函数：寻一可爬的地址，下载，标注，解析
        public void Crawl()
        {
            Console.WriteLine("开始爬行了.... ");
            //获取到域名地址
            domain = GetDomainName(startUrl);
            if (!urls.Contains(startUrl))
                urls.Add(startUrl, false);
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {//从集合中获取一个地址
                    if ((bool)urls[url]) continue;
                    current = url;//如果不为空，则
                }
                if (current == null || count > 10) break;
                Console.WriteLine("爬行" + current + "页面!");
                string html = DownLoad(current); // 下载
                urls[current] = true;//将当前爬取的网址置为已爬取
                count++;
                Parse(html);//解析,并加入新的链接
                Console.WriteLine("爬行结束");
            }
        }

        //下载，将目标url地址的内容下载到本地文件中，并返回html
        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        //在html文件中抽取出url地址，进行筛选和加工，放入到urls集合中
        private void Parse(string html)
        {
            // @"(href|HREF)[ ]*=[ ]*[""'][^""'#>]+[""']"
            string strRef = @"(href|HREF)[ ]*=[ ]*[""'][^""'#>]+.html[""']";//模式串
            MatchCollection matches = new Regex(strRef).Matches(html);//匹配器
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)//对匹配到的串进行裁剪
                    .Trim('"', '\"', '#', '>');
                //把相对地址变为绝对地址
                strRef = AbsoluteAddress(strRef);
                //判断是否为startUrl域名下的地址，如果是才有下文，如果不是continue
                //strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                if (IsInDomain(strRef) && strRef.Length == 0 && urls[strRef] == null)
                    urls[strRef] = false;//如果集合中尚未出现本条url，那么放入集合中，并且将值置为false
            }
        }

        //测试正确
        //传入startUrl，获取它的所在域名：如果它已经是根了，就算了，如果它不是那就返回根
        private String GetDomainName(String url)
        {   //裁剪出第三个反斜杠之前的部分。https：//asdasda/。要保留斜杠
            Console.WriteLine("进入GetDomainName(),获取域名地址");
            int i = url.IndexOf("/", 8, url.Length - 9);//得到第三次出现“/”的位置
            Console.WriteLine("i=" + i);
            if (i <= 0)
            {
                Console.WriteLine(url + "，它已经是一个根域名了，不需要再截取了。");
                return url;
            }
            url = url.Substring(0, i + 1);
            Console.WriteLine("截取到的域名地址为" + url);
            return url;
        }

        //把即将添加到urls中的新strRef传入，如果它是一个相对地址，将他转化为绝对地址
        private String AbsoluteAddress(String url)
        {
            Console.WriteLine("进入AbsoluteAddress，获取绝对地址");
            string pattern = @"^(https://|http://)";//模式串
            Console.WriteLine("传入的地址为" + url);
            if (Regex.IsMatch(url, pattern))//判断是否匹配，如果匹配直接返回，否则加上域名之后再返回
            {
                Console.WriteLine("该url是以https://或http://开头的，因此为绝对地址");
                return url;
            }
            Console.WriteLine("该url是相对地址，将其转化为绝对地址：" + domain + url);
            return domain + url;
        }

        //传入一个地址，判断是否为starUrl下的地址：正则匹配从头开始的那种
        private Boolean IsInDomain(String url)
        {
            Console.WriteLine("进入IsDomain函数，判断是否为域名之下的地址");
            string pattern = @"^" + domain;//相关domain
            if (Regex.IsMatch(url, pattern))
            {
                Console.WriteLine("是");
                return true;
            }
            Console.WriteLine("是");
            return false;
        }
    }
}

