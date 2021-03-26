using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Linq;
using System.Net;
using System.Xml.XPath;

namespace dab.xpath.query
{
    public class Filter
    {
    }

    public class Query
    {
        private IGetUri downloader;
        public Query(IGetUri downloader)
        {
            this.downloader = downloader;
        }
        public int Top { get; set; } = int.MaxValue;

        public delegate HtmlNodeCollection Selector(HtmlNode node);
        
        public Dictionary<string, object> Sources { get; set; } = new Dictionary<string, object>();

        public Dictionary<string, Tuple<Selector, string>> Selectors { get; set; } = new Dictionary<string, Tuple<Selector, string>>();

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

            doc.LoadHtml(downloader.Download(url));

            var node = doc.DocumentNode;

            if (xpaths != null && xpaths.Count() > 0)
            {
                try
                {
                    var nodes = this.getSelector(xpaths).Item1.Invoke(doc.DocumentNode);
                    this.Sources.Add(name, nodes);
                }
                catch(XPathException)
                {
                    throw new Exception("The XPath provided for the source yields no results: " + String.Join(",", xpaths));
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
                throw new Exception("The XPath provided to a selector yields no results: " + String.Join(",", xpaths));
            }

            return true;
        }

        private Tuple<Selector, string> getSelector(string[] xpaths)
        {
            try
            {
                var selectXpath = xpaths[xpaths.Length - 1];
                Selector selector = (HtmlNode node) => node.SelectNodes(selectXpath);

                for (var i = xpaths.Length - 2; i >= 0; i++)
                {
                    selector = (HtmlNode node) => selector.Invoke(node).First().SelectNodes(xpaths[i]);
                }

                return new Tuple<Selector, string>(selector, selectXpath);
            }
            catch(Exception ex)
            {
                throw ex;
            }
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

                var invoked = selector.Value.Item1.Invoke(child);

                if (invoked != null && invoked.Count > 0)
                {
                    var first = invoked.First();
                    var selectAttribute = selector.Value.Item2.Split('/').Last();
                    if (selectAttribute[0] != '@') selectAttribute = null;

                    if (!String.IsNullOrEmpty(selectAttribute))
                    {
                        childResult.Add(selector.Key, first.Attributes[selectAttribute.Substring(1)].Value.Trim());
                    }
                    else
                    {
                        childResult.Add(selector.Key, first.InnerText.Trim());
                    }
                    
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
