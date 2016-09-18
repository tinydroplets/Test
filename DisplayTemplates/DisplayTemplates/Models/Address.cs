using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DisplayTemplates.Models
{
    public class Address
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
    }
}