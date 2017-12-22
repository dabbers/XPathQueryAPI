# XPathQueryAPI
Gives you the ability to query a webpage using a "SQL" like language using XPaths to parse through webpages. 


Allows you to host a web API to allow you to easily query website data that might not be exposed through an API. 

An example:

http://www.nasdaq.com/symbol/msft/historical

Grabbing the data in the table:

The XPATH to the first row Open column:
//*[@id="quotes_content_left_pnlAJAX"]/table/tbody/tr[1]/td[2]

We can do nested xpaths on the URL in our SELECT FROM to reduce the size of our column xpath selectors:

SELECT 
    ".//td[2]" as "Open",
    ".//td[3]" as "High",
    ".//td[4]" as "Low"
FROM 
    "http://www.nasdaq.com/symbol/msft/historical"."//*[@id=\"quotes_content_left_pnlAJAX\"]/table/tbody/tr"


First we download the website, then perform the following XPATH on the document node.

Then, for each node in the collection, we perform the xpath for each desired column.

As might be recognized, we can rename the column with the 'as' so in the JSON response, we'll see a friendlier name for the column.

A sample result from thsi would look like:

[
    {"Open":85.40, "High":85.595, "Low":84.92},
    {"Open":85.40, "High":85.595, "Low":84.92},
    {"Open":85.40, "High":85.595, "Low":84.92},
    {"Open":85.40, "High":85.595, "Low":84.92},
    {"Open":85.40, "High":85.595, "Low":84.92},
    {"Open":85.40, "High":85.595, "Low":84.92}
]

