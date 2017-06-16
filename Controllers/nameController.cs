using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace restapi.Controllers
{
    public class nameController : ApiController
    {
        // GET: api/name
        public IEnumerable<string> Get()
        {
            return new string[] { "mike", "david" };
        }

        // GET: api/name/5
        public string Get(int id)
        {
            return id.ToString();
        }

        // POST: api/name
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/name/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/name/5
        public void Delete(int id)
        {
        }
    }
}
