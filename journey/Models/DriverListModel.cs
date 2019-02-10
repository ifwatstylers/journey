using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace journey.Models
{
    public class DriverListModel
    {
        //public string DriverName { get; set; }
        //public string DriverID { get; set; }
        //public string Email { get; set; }
        
        public List<string> DriverID = new List<string>();
        public List<string> Email = new List<string>();
    }
}