using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dab.xpath.query
{

    public class QueryBuilder : htmlapiBaseVisitor<Query>
    {
        private IGetUri downloader;
        private Query query = null;

        public QueryBuilder(IGetUri downloader)
        {
            this.downloader = downloader;
        }
        public override Query VisitQuery([NotNull] htmlapiParser.QueryContext context)
        {
            query = new Query(this.downloader);
            return base.VisitQuery(context);
        }

        private string Escape(string input)
        {
            return input.Substring(1, input.Length - 2).Replace("\\\"", "\"");
        }

        public override Query VisitColumnIdentifier([NotNull] htmlapiParser.ColumnIdentifierContext context)
        {
            var isFromClause = context.Parent.GetType() == typeof(htmlapiParser.SourceIdentifierContext);


            var children = context.children;
            if (children.Count == 0)
            {
                return query;
            }

            if (isFromClause)
            {
                string source, xpath;
                source = Escape(children.First().GetText());
                if (children.Count == 3)
                {
                    xpath = Escape(children[2].GetText());
                    query.AddSource(source, new string[] { xpath });

                }
                else
                {
                    query.AddSource(source);
                }
            }
            else
            {
                string xpath, name;
                xpath = name = Escape(children.First().GetText());
                if (children.Count == 3)
                {
                    name = Escape(children[2].GetText());
                }

                query.AddSelector(new string[] { xpath }, name);
            }

            return query;
        }

    }
}
