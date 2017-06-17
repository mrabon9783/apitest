using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using restapi.Models;
using Newtonsoft.Json;
using System.Web.Http.Results;

namespace restapi.Controllers
{
    public class loandocController : ApiController
    {
        // GET: api/loandoc

        public string Get()
        {
            //return new string[] { "mike", "david" };
            string r = "";
            return r;
        }

        // GET: api/loandoc/mrabon/deliverydashboard

        [HttpGet]
        public string Get(string user, string queryname )
        {
            string r = "";
            DeliveryDashboardPersistence t = new DeliveryDashboardPersistence();
            if(queryname=="deliverydashboard"| queryname == "deliverydashboard"|queryname == "deliverydashboard")
            {
                string sqlstr = "select * from dbo." + queryname + " where permitteduserid ='" + user + "'";
                r = t.fetchdb(sqlstr);
            }
            
            return r;
        }

        // POST: api/name
        //public HttpResponseMessage Post([FromBody]DeliveryDashboard value)
        //{
        //    DeliveryDashboardPersistence ddp = new DeliveryDashboardPersistence();
        //    long id;
        //    id = ddp.saveddb(value);
        //    value.id = id;
        //    HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
        //    response.Headers.Location = new Uri(Request.RequestUri, String.Format( "name/{0}",id));
        //    return response;
        //}

 

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
