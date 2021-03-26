using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dab.xpath.query;

namespace dab.xpath.api.Controllers
{
    [Route("api/[controller]")]
    public class XPathController : Controller
    {
        // GET api/values
        [HttpGet]
        public IActionResult Get(string query)
        {
            return Json(new QueryProcessor().ProcessQuery(query, new TimeoutWebClient(10)));
        }

    }
}