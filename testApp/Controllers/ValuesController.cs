using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace testApp.Controllers
{
    public class ValuesController : ApiController
    {
        // POST http://localhost/add
        [HttpPost]
        public int add(int value1, int value2)
        {
            return value1 + value2;
        }
    }
}
