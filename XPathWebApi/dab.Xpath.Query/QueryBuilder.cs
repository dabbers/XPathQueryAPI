using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dab.Xpath
{

    public class QueryBuilder : htmlapiBaseListener
    {
        public Query query = new Query();

        public override void EnterSingleQuery([NotNull] htmlapiParser.SingleQueryContext context)
        {
            var child = context.children[1];

            int index = 1;
            while (child is htmlapiParser.ColumnIdentifierContext column)
            {
                string rename = null;
                List<string> xpaths = new List<string>();
                // "qualifier" (. "qualifier")* as "qualifier"
                //  7           4    7          13      7
                bool doAs = false;
                foreach (var qChild in column.children)
                {
                    switch (((CommonToken)qChild.Payload).Type)
                    {
                        case htmlapiLexer.VALUE_STRING:
                            var value = qChild.GetText();
                            value = value.Substring(1, value.Length - 2).Replace("\\\"", "\"");

                            if (doAs)
                            {
                                rename = value;
                            }
                            else
                            {
                                xpaths.Add(value);
                            }

                            break;
                        case htmlapiLexer.T__3: // .

                            break;
                        case htmlapiLexer.AS:
                            doAs = true;
                            break;
                        default:
                            throw new Exception("Unexpected token: " + ((CommonToken)qChild.Payload).Type);
                    }
                }

                if (String.IsNullOrEmpty(rename))
                {
                    rename = xpaths.First();
                }

                this.query.AddSelector(xpaths.ToArray(), rename);

                index++;
                child = context.children[index];

                if (child.GetText() == ",")
                {
                    index++;
                    child = context.children[index];
                }
            }

            index++;
            child = context.children[index];

            if (child is htmlapiParser.ColumnIdentifierContext selectors)
            {

                string rename = null;
                string url = null;

                List<string> xpaths = new List<string>();

                bool doAs = false;

                foreach (var qChild in selectors.children)
                {
                    switch (((CommonToken)qChild.Payload).Type)
                    {
                        case htmlapiLexer.VALUE_STRING:
                            var value = qChild.GetText();
                            value = value.Substring(1, value.Length - 2).Replace("\\\"", "\"");

                            if (doAs)
                            {
                                rename = value;
                            }
                            else
                            {
                                xpaths.Add(value);
                            }

                            break;
                        case htmlapiLexer.T__3: // .

                            break;
                        case htmlapiLexer.AS:
                            doAs = true;
                            break;
                        default:
                            throw new Exception("Unexpected token: " + ((CommonToken)qChild.Payload).Type);
                    }
                }

                url = xpaths.First();
                xpaths.RemoveAt(0);

                if (String.IsNullOrEmpty(rename))
                {
                    rename = url;
                }

                this.query.AddSource(url, xpaths.ToArray(), rename);
                //System.Diagnostics.Debugger.Break();
            }

            //System.Diagnostics.Debugger.Break();
        }

        public override void EnterWhereFilter([NotNull] htmlapiParser.WhereFilterContext context)
        {
            base.EnterWhereFilter(context);
        }
    }
}
