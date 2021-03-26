using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace dab.xpath.query
{
    public interface IGetUri
    {
        string Download(string uri);
    }

    public class TimeoutWebClient : WebClient, IGetUri
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

        public string Download(string uri)
        {
            return DownloadString(uri);
        }
    }
}
