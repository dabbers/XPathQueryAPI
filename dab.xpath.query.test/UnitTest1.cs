using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace dab.xpath.query.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var processor = new QueryProcessor();
            var response = @"
            <html>
            <body>
            <div>
                Test
            </div>
            <div>
                Test 2
            </div>
            </body>
            </html>
            ";
            var result = processor.ProcessQuery(
                @"SELECT ""./div[1]"" as ""First"", ""./div[2]"" FROM ""http://2134"".""/html/body""", 
                new TestDownloader(response));
            
            Assert.AreEqual("Test", result[0].First);

            var second = result[0] as IDictionary<string, dynamic>;

            Assert.AreEqual("Test 2", second["./div[2]"]);
        }
    }

    class TestDownloader : IGetUri
    {
        private string response;

        public TestDownloader(string response)
        {
            this.response = response;
        }
        public string Download(string uri)
        {
            return response;
        }
    }
}
