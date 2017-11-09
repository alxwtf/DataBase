using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataBase.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string site { get; set; }
        public string industry { get; set; }
    }
}