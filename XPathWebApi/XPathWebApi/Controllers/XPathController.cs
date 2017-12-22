using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dab.Xpath;

namespace XPathWebApi.Controllers
{
    [Route("api/[controller]")]
    public class XPathController : Controller
    {
        // GET api/values
        [HttpGet]
        public IActionResult Get(string query)
        {
            return Json(QueryProcessor.ProcessQuery(query));
        }
        
    }
}
