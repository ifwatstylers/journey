using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace journey.Models
{
    public class DriverModel
    {
        public string Period { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string lblFromTo { get; set; }
        public string DateSelected { get; set; }
        public string Time { get; set; }
        public string FromTextBox { get; set; }
        public string ToTextBox { get; set; }
        public string Email { get; set; }
    }
}