using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Text;

namespace dab.Xpath
{
    public static class QueryProcessor
    {
        public static dynamic ProcessQuery(string query)
        {
            var input = new AntlrInputStream(query);

            htmlapiLexer lexer = new htmlapiLexer(input);
            lexer.AddErrorListener(new ErrorParserListener());

            CommonTokenStream tokenStream = new CommonTokenStream(lexer);
            htmlapiParser parser = new htmlapiParser(tokenStream);

            var queryctx = parser.query();

            ParseTreeWalker walker = new ParseTreeWalker();
            QueryBuilder builder = new QueryBuilder();
            walker.Walk(builder, queryctx);
            
            var result = builder.query.Execute();

            return result;
        }
    }
}
