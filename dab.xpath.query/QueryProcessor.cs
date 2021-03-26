using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Text;

namespace dab.xpath.query
{
    public class QueryProcessor
    {
        public dynamic ProcessQuery(string query, IGetUri downloader)
        {
            var input = new AntlrInputStream(query);

            htmlapiLexer lexer = new htmlapiLexer(input);
            lexer.AddErrorListener(new ErrorParserListener());

            CommonTokenStream tokenStream = new CommonTokenStream(lexer);
            htmlapiParser parser = new htmlapiParser(tokenStream);
            var builder = new QueryBuilder(downloader);
            Query output = builder.VisitQuery(parser.query());
            return output.Execute();
        }
    }
}
