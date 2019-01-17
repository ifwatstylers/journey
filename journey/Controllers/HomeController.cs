//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using journey.Models;
//using System.Data.SqlClient;
//using System.Net;
//using System.Net.Mail;
//using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using journey.Models;
using System.Net;
using System.Net.Mail;
using System.Configuration;
using System.Data.SqlClient;
using System.Web;
using System.IO;

namespace journey.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    return View();
        //}
        
        public ActionResult Index(CustomerModel customer, FormCollection formcollection, string projectName)
        {
            
            #region LOAD TOL INTO DROPDOWNLIST
            //load TOL from to here
            String connectionString3 = "Server=tcp:festive.database.windows.net,1433;Initial Catalog=FestiveDB;Persist Security Info=False;User ID=admin_festive;Password=P@55w0rd2018;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

                String sql3 = "select * from poi2 where PLACE_CAT = 'tp'";

                SqlConnection conn3 = new SqlConnection(connectionString3);

                SqlCommand cmd3 = new SqlCommand(sql3, conn3);

                var model3 = customer.ListTolFromTo.ToList();

                using (conn3)
                {
                    conn3.Open();
                    SqlDataReader rdr = cmd3.ExecuteReader();

                    while (rdr.Read())
                    {
                        var TolPlaza = new Student();
                        TolPlaza.FirstName = rdr["PLACE_NAME"].ToString();

                        model3.Add(TolPlaza.FirstName.ToString());
                    }

                }
                customer.ListTolFromTo = model3;

            //end load TOL from to
            #endregion

            //if (customer.From != null || customer.To != null || customer.Period != null)
            #region load RSA here
            if (customer.From != null) //for testing need to change to == // for dev need to change to !=
            {
                //dummy
                //customer.From = "SUBANG JAYA";
                //customer.To = "BIDOR";
                //dummy

                String connectionString = "Server=tcp:festive.database.windows.net,1433;Initial Catalog=FestiveDB;Persist Security Info=False;User ID=admin_festive;Password=P@55w0rd2018;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                
                String sqlForPlaceIDFrom = "select * from poi2 where PLACE_NAME = '" + customer.From + "' and PLACE_CAT = 'tp'";
                String sqlForPlaceIDTo = "select * from poi2 where PLACE_NAME = '" + customer.To + "' and PLACE_CAT = 'tp'";
                //int DriverFROM = 70;// Int32.Parse(customer.From);
                //int DriverTO = 10;// Int32.Parse(customer.To);
               string idFrom;
                string idto;
                string idFromGroup;
                string idtoGroup;

                SqlConnection connCheckIDFrom = new SqlConnection(connectionString);
                SqlCommand cmdCheckIDfrom = new SqlCommand(sqlForPlaceIDFrom, connCheckIDFrom);
                using (connCheckIDFrom)
                {
                    connCheckIDFrom.Open();
                    
                    SqlDataReader rdr = cmdCheckIDfrom.ExecuteReader();
                    while (rdr.Read())
                    {
                        idFrom = rdr["ID"].ToString();
                        customer.DriverFROM = Int32.Parse(idFrom);
                        idFromGroup = rdr["GROUP_ID"].ToString();
                        customer.DriverFROMGroudID = Int32.Parse(idFromGroup);
                    }
                    connCheckIDFrom.Close();
                }

                SqlConnection connCheckIDto = new SqlConnection(connectionString);
                SqlCommand cmdCheckIDto = new SqlCommand(sqlForPlaceIDTo, connCheckIDto);
                using (connCheckIDto)
                {
                    connCheckIDto.Open();
                    SqlDataReader rdr = cmdCheckIDto.ExecuteReader();
                    while (rdr.Read())
                    {
                        idto = rdr["ID"].ToString();
                        customer.DriverTO = Int32.Parse(idto);
                        idtoGroup = rdr["GROUP_ID"].ToString();
                        customer.DriverTOGroupID = Int32.Parse(idtoGroup);
                    }
                    connCheckIDto.Close();
                }
                int DriverFROM = customer.DriverFROM;
                int DriverTO = customer.DriverTO;

                #region FOR CALCULATE GROUP CLUSTER FOR SET TIME FOR DEPARTURE
                int DriverFROMforGroup = customer.DriverFROMGroudID;
                int DriverTOforGroup = customer.DriverTOGroupID;

                int ansForClusterDiff = DriverFROMforGroup - DriverTOforGroup;
                if (ansForClusterDiff == 1 || ansForClusterDiff == -1)
                {
                    //7 pm
                    customer.Time = "7:00pm";
                    ViewBag.displayTimeText = " After 7:00pm";
                }
                else if (ansForClusterDiff == 2 || ansForClusterDiff == -2)
                {
                    //12pm
                    customer.Time = "12:00pm";
                    ViewBag.displayTimeText = "After 12:00pm";
                }
                else if (ansForClusterDiff >= 3 || ansForClusterDiff <= -3)
                {
                    //7:00am
                    customer.Time = "7:00am";
                    ViewBag.displayTimeText = "Before 7:00am";
                }
                #endregion

                String sql;
                if (DriverFROM < DriverTO)//if (checkUtaraSelatan < 0)
                {
                    sql = "select * from poi2 where PLACE_CAT = 'rsa' and(id > " + DriverFROM + " and id < " + DriverTO + ") order by id asc";
                }
                else if (DriverFROM == DriverTO)
                {
                    sql = "select * from poi2 where PLACE_CAT = 'rsa' and(id > " + DriverFROM + " and id < " + DriverTO + ")";
                }
                else
                {
                    sql = "select * from poi2 where PLACE_CAT = 'rsa' and(id > " + DriverTO + " and id < " + DriverFROM  + ") order by id desc";
                }

                SqlConnection conn2 = new SqlConnection(connectionString);
                SqlCommand cmd2 = new SqlCommand(sql, conn2);

                var model2 = customer.ListRSA.ToList();
                var modelForNameRSa = customer.ListRSA.ToList();

                using (conn2)
                {
                    conn2.Open();
                    SqlDataReader rdr = cmd2.ExecuteReader();

                    while (rdr.Read())
                    {
                        var customer2 = new Student();

                        //customer2.FirstName = rdr["PLACE_NAME"].ToString();
                        customer2.FirstName = rdr["image_url"].ToString();
                        customer2.LastName = rdr["PLACE_NAME"].ToString();
                        //customer2.LastName = rdr["LastName"].ToString();
                        //customer.Class = rdr["Class"].ToString();


                        model2.Add(customer2.FirstName.ToString());
                        modelForNameRSa.Add(customer2.LastName.ToString());

                    }

                }


                customer.ListRSA = model2;
                customer.ListRSAName = modelForNameRSa;
            }

            #endregion end load RSA here
            //}

            string constr = "Server=tcp:festive.database.windows.net,1433;Initial Catalog=FestiveDB;Persist Security Info=False;User ID=admin_festive;Password=P@55w0rd2018;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
           
            using (SqlConnection conn = new SqlConnection(constr))
            {
                try
                {
                    conn.Open(); // throws if invalid
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }

            }
            if (customer.Email == null)
            {
                //string messagetodisplay = "please fill up email";
            }
            else
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    customer.Date = customer.DateSelected;
                    //string query = "INSERT INTO Customers(Name, Country) VALUES(@Name, @Country)";
                    string query = "INSERT INTO Driver (Email, LocFrom, LocTo, DepartDate, DepartTime) VALUES (@Email, @From, @To, @Date, @Time)";
                    query += " SELECT SCOPE_IDENTITY()";
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Connection = con;
                        con.Open();
                        
                        cmd.Parameters.AddWithValue("@Email", customer.Email);
                        cmd.Parameters.AddWithValue("@From", customer.FromTextBox);
                        cmd.Parameters.AddWithValue("@To", customer.ToTextBox);
                        cmd.Parameters.AddWithValue("@Date", customer.Date);
                        cmd.Parameters.AddWithValue("@Time", customer.Time);
                        cmd.ExecuteScalar();
                        //customer.CustomerId = Convert.ToInt32(cmd.ExecuteScalar());
                        con.Close();
                    }
                }

            }


            //FOR SENDING EMAIL FUNCTION
            if (customer.From != null) //for testing need to change to == // for dev need to change to !=
            {
                //IndexAsync(customer);
                EmailFormModel model2;
               

                 SentEmail();
            }
            //END FOR SENDING EMAIL FUNCTION
            if (customer.Email != null)
            {
                return RedirectToAction("ThankYou", "Home");
            }
            else
                return View(customer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> IndexAsync(CustomerModel customer)
        {
            //customer.FromName = "";
            //customer.Message = "";
            customer.FromEmail = customer.Email;
            
            // if (ModelState.IsValid)
            if (customer.FromEmail != null)
            {
                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress(customer.FromEmail));  // replace with valid value 
                message.From = new MailAddress("ifwat.ibrahim@plus.uemnet.com");  // replace with valid value
                message.Subject = "PLUS - CNY 2019";
                message.Body = string.Format(body, customer.FromName, customer.FromEmail, customer.Message);
                message.IsBodyHtml = true;

                string htmlBody;

                string from = customer.From;// "Jalan Duta";
                string to = customer.To; // "Bukit Kayu Hitam";
                string date = customer.Date;// "2 Feb 2019";
                string time = customer.Time;// "09:00 am";
                string traffic = "Peak";

                htmlBody = "<!DOCTYPE html>" +
                            "<html>" +
                            "<head>" +
                            "<meta name=\"viewport\" content=\"width = device - width, initial - scale = 1.0\">" +
                                    "<style>" +
                                    "* {" +
                                    "  box-sizing: border-box;" +
                                    "}" +
                                    ".menu {" +
                                    "  float: left;" +
                                    "  width: 20%;" +
                                    "}" +
                                    ".menuitem {" +
                                    "  padding: 8px;" +
                            "  margin-top: 7px;" +
                            "  border-bottom: 1px solid #f1f1f1;" +
                            "}" +
                            ".main {" +
                            "  float: left;" +
                            "  width: 60%;" +
                            "  padding: 0 20px;" +
                            "  overflow: hidden;" +
                            "}" +
                            ".right {" +
                            "  background-color: lightblue;" +
                            "  float: left;" +
                            "  width: 20%;" +
                            "  padding: 10px 15px;" +
                            "  margin-top: 7px;" +
                            "}" +
                            "" +
                            "@media only screen and (max-width:800px) {" +
                            "  /* For tablets: */" +
                            "  .main {" +
                            "    width: 80%;" +
                            "    padding: 0;" +
                            "  }" +
                            "  .right {" +
                            "    width: 100%;" +
                            "  }" +
                            "}" +
                            "@media only screen and (max-width:500px) {" +
                            "  /* For mobile phones: */" +
                            "  .menu, .main, .right {" +
                            "    width: 100%;" +
                            "  }" +
                            "}" +
                            "</style>" +
                            "</head>" +
                            "<body style=\"font-family:Verdana;\">" +
                            "" +
                            "<div style=\"background-color:#f1f1f1;padding:15px;\">" +
                            "  <h1>PLUS MALAYSIA BERHAD</h1>" +
                            "  <h3>Chinese New Year 2019</h3>" +
                            "</div>" +
                            "" +
                            "<div style=\"overflow:auto\">" +
                            "  <div class=\"main\">" +
                            "    <h2 style=\"align:center\">Win The \"Buah Tangan\"</h2>" +
                            "    <p style=\"align:center\">The walk from Monterosso to Riomaggiore will take you approximately two hours, give or take an hour depending on the weather conditions and your physical shape.</p>" +
                            "    <img src=\"https://lh6.googleusercontent.com/ne1YwodmX1LPFtSWXepVmKS1OD15GPOv8PHB2jmE5qsrFjCp8VVykRiEq0V-VkzjsNKNFPJhKlIy5oFwg1d4=w1334-h571 \" style=\"width:100%; align:center;\">" +
                            "  </div>" +
                            "" +
                            "  <div class=\"right\">" +
                            "    <h2> Your Journey </h2> " +
                            "    <p> From: " + from.ToString() + "<br/> To: " + to.ToString() + " </p>" +
                            "    <h2>Travel Date & Time</h2>" +
                            "    <p> " + date.ToString() + " " + time.ToString() + " </p>" +
                            "    <h2>Traffic Estimated</h2>" +
                            "    <p> " + traffic.ToString() + "</p>" +
                            "  </div>" +
                            "</div>" +
                            "" +
                            "" +
                            "<div style=\"background-color:#f1f1f1;text-align:center;padding:10px;margin-top:7px;font-size:12px;\"> This web page is a part of a demonstration of fluid web design made by plus.com</div>" +
                            "" +
                            "</body>" +
                            "</html>";

                message.Body = htmlBody;
                
                using (var smtp = new SmtpClient())
                {
                    //SmtpClient SmtpServer = new SmtpClient(smtp.ToString());
                    var credential = new NetworkCredential
                    {
                        UserName = "ifwat.ibrahim@plus.uemnet.com",  // replace with valid value
                        Password = "T@hun2018"  // replace with valid value
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp-mail.outlook.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    try { await smtp.SendMailAsync(message); }
                    catch (Exception ex)
                    { string error = ex.ToString();}
                    //return RedirectToAction("Sent");
                    //return View("/Home/About");
                    //return Json(new { redirectToUrl = Url.Action("Index", "About") });
                    
                }
            }
                return View(customer);
        }
        

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ThankYou()
        {
            ViewBag.Message = "Your Thank You page.";

            return View();
        }

        public ActionResult SentEmail()
        {
            ViewBag.Message = "Page for Sent Email.";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SentEmail(EmailFormModel model)
        {
            if (ModelState.IsValid)
            {
                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("ifwat.ibrahim@plus.uemnet.com"));  // replace with valid value 
                message.From = new MailAddress("ifwat.ibrahim@plus.uemnet.com");  // replace with valid value
                message.Subject = "Your email subject";
                message.Body = string.Format(body, model.FromName, model.FromEmail, model.Message);
                message.IsBodyHtml = true;

                string htmlBody;

                string from = "Jalan Duta";
                string to =  "Bukit Kayu Hitam";
                string date =  "2 Feb 2019";
                string time =  "09:00 am";
                string traffic = "Peak";

                htmlBody = "<!DOCTYPE html>" +
                            "<html>" +
                            "<head>" +
                            "<meta name=\"viewport\" content=\"width = device - width, initial - scale = 1.0\">" +
                                    "<style>" +
                                    "* {" +
                                    "  box-sizing: border-box;" +
                                    "}" +
                                    ".menu {" +
                                    "  float: left;" +
                                    "  width: 20%;" +
                                    "}" +
                                    ".menuitem {" +
                                    "  padding: 8px;" +
                            "  margin-top: 7px;" +
                            "  border-bottom: 1px solid #f1f1f1;" +
                            "}" +
                            ".main {" +
                            "  float: left;" +
                            "  width: 60%;" +
                            "  padding: 0 20px;" +
                            "  overflow: hidden;" +
                            "}" +
                            ".right {" +
                            "  background-color: lightblue;" +
                            "  float: left;" +
                            "  width: 20%;" +
                            "  padding: 10px 15px;" +
                            "  margin-top: 7px;" +
                            "}" +
                            "" +
                            "@media only screen and (max-width:800px) {" +
                            "  /* For tablets: */" +
                            "  .main {" +
                            "    width: 80%;" +
                            "    padding: 0;" +
                            "  }" +
                            "  .right {" +
                            "    width: 100%;" +
                            "  }" +
                            "}" +
                            "@media only screen and (max-width:500px) {" +
                            "  /* For mobile phones: */" +
                            "  .menu, .main, .right {" +
                            "    width: 100%;" +
                            "  }" +
                            "}" +
                            "</style>" +
                            "</head>" +
                            "<body style=\"font-family:Verdana;\">" +
                            "" +
                            "<div style=\"background-color:#f1f1f1;padding:15px;\">" +
                            "  <h1>PLUS MALAYSIA BERHAD</h1>" +
                            "  <h3>Chinese New Year 2019</h3>" +
                            "</div>" +
                            "" +
                            "<div style=\"overflow:auto\">" +
                            "  <div class=\"main\">" +
                            "    <h2 style=\"align:center\">Win The \"Buah Tangan\"</h2>" +
                            "    <p style=\"align:center\">The walk from Monterosso to Riomaggiore will take you approximately two hours, give or take an hour depending on the weather conditions and your physical shape.</p>" +
                            "    <img src=\"https://journeyplus.azurewebsites.net/images/bnr_1024px_b.jpg \" style=\"width:100%; align:center;\">" +
                            "  </div>" +
                            "" +
                            "  <div class=\"right\">" +
                            "    <h2> Your Journey </h2> " +
                            "    <p> From: " + from.ToString() + "<br/> To: " + to.ToString() + " </p>" +
                            "    <h2>Travel Date & Time</h2>" +
                            "    <p> " + date.ToString() + " " + time.ToString() + " </p>" +
                            "    <h2>Traffic Estimated</h2>" +
                            "    <p> " + traffic.ToString() + "</p>" +
                            "  </div>" +
                            "</div>" +
                            "" +
                            "" +
                            "<div style=\"background-color:#f1f1f1;text-align:center;padding:10px;margin-top:7px;font-size:12px;\"> This web page is a part of a demonstration of fluid web design made by plus.com</div>" +
                            "" +
                            "</body>" +
                            "</html>";

                message.Body = htmlBody;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "ifwat.ibrahim@plus.uemnet.com",  // replace with valid value
                        Password = "T@hun2018"  // replace with valid value
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp-mail.outlook.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("ThankYou");
                }
            }
            return View(model);
        }
        //public async Task<ActionResult> SentEmail(EmailFormModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
        //        var message = new MailMessage();
        //        message.To.Add(new MailAddress("ifwat.ibrahim@gmail.com"));  // replace with valid value 
        //        message.From = new MailAddress("ifwat.ibrahim@plus.uemnet.com");  // replace with valid value
        //        message.Subject = "Your email subject";
        //        message.Body = string.Format(body, model.FromName, model.FromEmail, model.Message);
        //        message.IsBodyHtml = true;

        //        using (var smtp = new SmtpClient())
        //        {
        //            var credential = new NetworkCredential
        //            {
        //                UserName = "ifwat.ibrahim@plus.uemnet.com",  // replace with valid value
        //                Password = "T@hun2018"  // replace with valid value
        //            };
        //            smtp.Credentials = credential;
        //            smtp.Host = "smtp-mail.outlook.com";
        //            smtp.Port = 587;
        //            smtp.EnableSsl = true;
        //            await smtp.SendMailAsync(message);
        //            return RedirectToAction("ThankYou");
        //        }
        //    }
        //    return View(model);
        //}
    }
}