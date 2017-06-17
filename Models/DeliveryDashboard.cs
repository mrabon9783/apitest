using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace restapi.Models
{
    public class DeliveryDashboard
    {
        public long id { get; set; }
        public DateTime BoardDate { get; set; }
        public long TotalLoans { get; set; }
        public long MissingDocuments { get; set; }
    }

}