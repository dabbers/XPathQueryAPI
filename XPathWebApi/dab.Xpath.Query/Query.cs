using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Linq;
using System.Net;
using System.Xml.XPath;

namespace dab.Xpath
{
    public class Filter
    {

    }


    public class TimeoutWebClient : WebClient
    {
        public TimeoutWebClient(int timeout = 30)
        {
            this.timeout = timeout;
        }
        int timeout = 30;
        protected override WebRequest GetWebRequest(Uri uri)
        {
            WebRequest w = base.GetWebRequest(uri);
            w.Timeout = (int)TimeSpan.FromSeconds(this.timeout).TotalMilliseconds;
            return w;
        }

    }

    public class Query
    {
        public int Top { get; set; } = int.MaxValue;

        public delegate HtmlNodeCollection Selector(HtmlNode node);
        
        public Dictionary<string, object> Sources { get; set; } = new Dictionary<string, object>();

        public Dictionary<string, Selector> Selectors { get; set; } = new Dictionary<string, Selector>();

        public List<Filter> Conditions { get; set; } = new List<Filter>();



        public bool AddSource(string url)
        {
            return AddSource(url, null, url);
        }

        public bool AddSource(string url, string[] xpaths)
        {
            return AddSource(url, xpaths, url);
        }

        public bool AddSource(string url, string[] xpaths, string name)
        {
            var doc = new HtmlDocument();
            if (url.IndexOf("http") != 0)
            {
                throw new Exception("Invalid source url");
            }

            doc.LoadHtml(new TimeoutWebClient(10).DownloadString(url));

            var node = doc.DocumentNode;

            if (xpaths != null && xpaths.Count() > 0)
            {
                try
                {
                    var nodes = this.getSelector(xpaths).Invoke(doc.DocumentNode);
                    this.Sources.Add(name, nodes);
                }
                catch(XPathException)
                {
                    throw new Exception("The XPath provided for the source yields no results: " + String.Join(',', xpaths));
                }
            }
            else
            {
                this.Sources.Add(name, doc.DocumentNode);
            }


            return true;
        }

        public bool AddSelector(string[] xpaths, string name)
        {
            try
            {
                this.Selectors.Add(name, this.getSelector(xpaths));
            }
            catch(XPathException)
            {
                throw new Exception("The XPath provided to a selector yields no results: " + String.Join(',', xpaths));
            }

            return true;
        }

        private Selector getSelector(string[] xpaths)
        {
            Selector selector = (HtmlNode node) => node.SelectNodes(xpaths[xpaths.Length - 1]);

            for(var i = xpaths.Length - 2; i >= 0; i++)
            {
                selector = (HtmlNode node) => selector.Invoke(node).First().SelectNodes(xpaths[i]);
            }

            return selector;
        }

        private bool xpathPerform(HtmlNode child, List<dynamic> results)
        {
            var childResult = new ExpandoObject() as IDictionary<string, object>;

            foreach (var selector in this.Selectors)
            {
                if ((results.Count) > this.Top)
                {
                    results.AddRange(results);
                    return false;
                }

                var invoked = selector.Value.Invoke(child);

                if (invoked != null && invoked.Count > 0)
                {
                    childResult.Add(selector.Key, invoked.First().InnerText.Trim());
                }
                else
                {
                    childResult.Add(selector.Key, null);
                }
            }

            results.Add(childResult);
            return true;
        }

        public dynamic[] Execute()
        {
            List<dynamic> results = new List<dynamic>(); ; // new List<dynamic>();

            foreach (var source in this.Sources)
            {
                //List<dynamic> rows = new List<dynamic>();

                if (source.Value is HtmlNodeCollection collection)
                {
                    foreach (var child in collection)
                    {
                        if (!xpathPerform(child, results))
                        {
                            return results.ToArray();
                        }
                    }
                }
                else if (source.Value is HtmlNode node)
                {
                    xpathPerform(node, results);
                }
            }

            //results.AddRange(results);
            return results.ToArray();
        }

    }
}
