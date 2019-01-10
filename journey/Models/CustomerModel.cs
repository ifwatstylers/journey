using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace journey.Models
{
    //public class MainModel
    //{
    //    public CustomerModels CustomerModel { get; set; }
    //    public IEnumerable<Student> Students { get; set; }
    //}
    //HERE PART FOR LOAD RSA FROM DATABASE
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Class { get; set; }
        public List<string> NameLIST2 = new List<string>();
    }
    //END PART FOR LOAD RSA HERE
    public class CustomerModel
    {
        public int CustomerId { get; set; }

        public string Email { get; set; }

       // public string ListRSA { get; set; }

        public string ListMerchant { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public string Date { get; set; }

        public string Time { get; set; }
        //public string Time2 { get; set; }
        //public string Time3 { get; set; }
        //public string Time4 { get; set; }

        public string Period { get; set; }

        public string lblFromTo { get; set; }


        [Required, Display(Name = "Your name")]
        public string FromName { get; set; }
        [Required, Display(Name = "Your email"), EmailAddress]
        public string FromEmail { get; set; }
        [Required]
        public string Message { get; set; }

      
        public List<string> NameLIST = new List<string>();
        public List<string> ListRSA = new List<string>();
        public List<string> ListTolFromTo = new List<string>();

        public int DriverFROM;
        public int DriverTO;

        public string Gender { get; set; }
        public string DateSelected { get; set; }

        
    }
    


}