﻿//using System;
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
using System.Web.Configuration;

namespace journey.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //public ActionResult Index(CustomerModel customer, FormCollection formcollection, string projectName)
        //{

        //    #region LOAD TOL INTO DROPDOWNLIST

        //    String connectionString3 = "Server=tcp:festive.database.windows.net,1433;Initial Catalog=FestiveDB;Persist Security Info=False;User ID=admin_festive;Password=P@55w0rd2018;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        //    String sql3 = "select * from poi2 where PLACE_CAT = 'tp'";

        //    SqlConnection conn3 = new SqlConnection(connectionString3);

        //    SqlCommand cmd3 = new SqlCommand(sql3, conn3);

        //    var model3 = customer.ListTolFromTo.ToList();

        //    using (conn3)
        //    {
        //        conn3.Open();
        //        SqlDataReader rdr = cmd3.ExecuteReader();

        //        while (rdr.Read())
        //        {
        //            var TolPlaza = new Student();
        //            TolPlaza.FirstName = rdr["PLACE_NAME"].ToString();

        //            model3.Add(TolPlaza.FirstName.ToString());
        //        }

        //    }
        //    customer.ListTolFromTo = model3;


        //    #endregion


        #region load RSA here
        //    if (customer.From != null) 
        //    {




        //        String sqlForPlaceIDFrom = "select * from poi2 where PLACE_NAME = '" + customer.From + "' and PLACE_CAT = 'tp'";
        //        String sqlForPlaceIDTo = "select * from poi2 where PLACE_NAME = '" + customer.To + "' and PLACE_CAT = 'tp'";

        //        string idFrom;
        //        string idto;
        //        string idFromGroup;
        //        string idtoGroup;

        //        String connectionString = "Server=tcp:festive.database.windows.net,1433;Initial Catalog=FestiveDB;Persist Security Info=False;User ID=admin_festive;Password=P@55w0rd2018;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        //        SqlConnection connCheckIDFrom = new SqlConnection(connectionString);
        //        SqlCommand cmdCheckIDfrom = new SqlCommand(sqlForPlaceIDFrom, connCheckIDFrom);
        //        using (connCheckIDFrom)
        //        {
        //            connCheckIDFrom.Open();

        //            SqlDataReader rdr = cmdCheckIDfrom.ExecuteReader();
        //            while (rdr.Read())
        //            {
        //                idFrom = rdr["ID"].ToString();
        //                customer.DriverFROM = Int32.Parse(idFrom);
        //                idFromGroup = rdr["GROUP_ID"].ToString();
        //                customer.DriverFROMGroudID = Int32.Parse(idFromGroup);
        //            }
        //            connCheckIDFrom.Close();
        //        }

        //        SqlConnection connCheckIDto = new SqlConnection(connectionString);
        //        SqlCommand cmdCheckIDto = new SqlCommand(sqlForPlaceIDTo, connCheckIDto);
        //        using (connCheckIDto)
        //        {
        //            connCheckIDto.Open();
        //            SqlDataReader rdr = cmdCheckIDto.ExecuteReader();
        //            while (rdr.Read())
        //            {
        //                idto = rdr["ID"].ToString();
        //                customer.DriverTO = Int32.Parse(idto);
        //                idtoGroup = rdr["GROUP_ID"].ToString();
        //                customer.DriverTOGroupID = Int32.Parse(idtoGroup);
        //            }
        //            connCheckIDto.Close();
        //        }
        //        int DriverFROM = customer.DriverFROM;
        //        int DriverTO = customer.DriverTO;

                #region FOR CALCULATE GROUP CLUSTER FOR SET TIME FOR DEPARTURE
        //        int DriverFROMforGroup = customer.DriverFROMGroudID;
        //        int DriverTOforGroup = customer.DriverTOGroupID;

        //        int ansForClusterDiff = DriverFROMforGroup - DriverTOforGroup;
        //        if (ansForClusterDiff == 1 || ansForClusterDiff == -1)
        //        {

        //            customer.Time = "7:00pm";
        //            ViewBag.displayTimeText = " After 7:00pm";
        //        }
        //        else if (ansForClusterDiff == 2 || ansForClusterDiff == -2)
        //        {

        //            customer.Time = "12:00pm";
        //            ViewBag.displayTimeText = "After 12:00pm";
        //        }
        //        else if (ansForClusterDiff >= 3 || ansForClusterDiff <= -3)
        //        {

        //            customer.Time = "7:00am";
        //            ViewBag.displayTimeText = "Before 7:00am";
        //        }
        #endregion

        //        String sql;
        //        if (DriverFROM < DriverTO)
        //        {
        //            sql = "select * from poi2 where PLACE_CAT = 'rsa' and(id > " + DriverFROM + " and id < " + DriverTO + ") order by id asc";
        //        }
        //        else if (DriverFROM == DriverTO)
        //        {
        //            sql = "select * from poi2 where PLACE_CAT = 'rsa' and(id > " + DriverFROM + " and id < " + DriverTO + ")";
        //        }
        //        else
        //        {
        //            sql = "select * from poi2 where PLACE_CAT = 'rsa' and(id > " + DriverTO + " and id < " + DriverFROM + ") order by id desc";
        //        }

        //        SqlConnection conn2 = new SqlConnection(connectionString);
        //        SqlCommand cmd2 = new SqlCommand(sql, conn2);

        //        var model2 = customer.ListRSA.ToList();
        //        var modelForNameRSa = customer.ListRSA.ToList();

        //        using (conn2)
        //        {
        //            conn2.Open();
        //            SqlDataReader rdr = cmd2.ExecuteReader();

        //            while (rdr.Read())
        //            {
        //                var customer2 = new Student();

        //                customer2.FirstName = rdr["image_url"].ToString();
        //                customer2.LastName = rdr["PLACE_NAME"].ToString();


        //                model2.Add(customer2.FirstName.ToString());
        //                modelForNameRSa.Add(customer2.LastName.ToString());

        //            }

        //        }


        //        customer.ListRSA = model2;
        //        customer.ListRSAName = modelForNameRSa;
        //    }

            #endregion end load RSA here

        //    string constr = "Server=tcp:festive.database.windows.net,1433;Initial Catalog=FestiveDB;Persist Security Info=False;User ID=admin_festive;Password=P@55w0rd2018;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        //    using (SqlConnection conn = new SqlConnection(constr))
        //    {
        //        try
        //        {
        //            conn.Open(); 
        //        }
        //        catch (Exception ex)
        //        {
        //            ex.ToString();
        //        }

        //    }
        //    if (customer.Email == null)
        //    {
        //    }
        //    else
        //    {
        //        using (SqlConnection con = new SqlConnection(constr))
        //        {
        //            customer.Date = customer.DateSelected;
        //            string query = "INSERT INTO Driver (Email, LocFrom, LocTo, DepartDate, DepartTime) VALUES (@Email, @From, @To, @Date, @Time)";
        //            query += " SELECT SCOPE_IDENTITY()";
        //            using (SqlCommand cmd = new SqlCommand(query))
        //            {
        //                cmd.Connection = con;
        //                con.Open();

        //                cmd.Parameters.AddWithValue("@Email", customer.Email);
        //                cmd.Parameters.AddWithValue("@From", customer.FromTextBox);
        //                cmd.Parameters.AddWithValue("@To", customer.ToTextBox);
        //                cmd.Parameters.AddWithValue("@Date", customer.Date);
        //                cmd.Parameters.AddWithValue("@Time", customer.Time);
        //                cmd.ExecuteScalar();
        //                con.Close();
        //            }
        //        }

        //    }


        //    if (customer.From != null) 
        //    {
        //        IndexAsync(customer);
        //    }
        //    if (customer.Email != null)
        //    {
        //        return RedirectToAction("ThankYou", "Home");
        //    }
        //    else
        //        return View(customer);
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> IndexLamaAsync(CustomerModel customer)
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

                string from = "Jalan Duta";
                string to ="Bukit Kayu Hitam";
                string date = "2 Feb 2019";
                string time = "09:00 am";
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

       

        public ActionResult StayTune()
        {
            return View();
        }
        
        public PartialViewResult Home()
        {
            return PartialView("~/Admin/home.cshtml");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult DriverList(DriverListModel model)
        {
            ViewBag.Message = "Database Result";

            String connectionString = "Server=tcp:festive.database.windows.net,1433;Initial Catalog=FestiveDB_staging;Persist Security Info=False;User ID=admin_festive;Password=P@55w0rd2018;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            String sql = "SELECT * FROM Driver";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);

            var model2 = new List<DriverListModel>();
            using (conn = new SqlConnection(connectionString))
            {
                
                SqlDataReader rdr = cmd.ExecuteReader();
                var pemandu = model.Email.ToList();
                while (rdr.Read())
                {
                    
                    //pemandu = rdr["id"].ToString();
                    //pemandu.Email = rdr["email"].ToString();

                    //model2.Add(pemandu);
                }
            }
            //model = model2;
            //var entities = new DRIVER();

            //return View(entities);

            return View(model);
        }

        public ActionResult ThankYou()
        {
            ViewBag.Message = "Your Thank You page.";

            return View();
        }

        public ActionResult Error()
        {
            //if (ErrorMsg != null)
            //{
            //    ViewBag.Message = ErrorMsg.ToString();
            //}
            //else { 
            ViewBag.Message = "This page will appear if system run error accidently!"; 
            

            return View();
        }

        public ActionResult SentEmail()
        {
            ViewBag.Message = "Page for Sent Email.";

            return View();
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Home Page";

            return View();
        }

        public ActionResult SafeDrive()
        {
            return View();
        }

        public ActionResult Contest()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contest(ContestModel model)
        {
            if (model.Email != null && model.Name != null && model.IC != null && model.PhoneNo != null)
            {
                try
                {
                    string constr = WebConfigurationManager.AppSettings["DBConStringLMSLoyaltyPROD"];
                    using (SqlConnection con = new SqlConnection(constr))
                    {
                        con.Open(); // throws if invalid

                        string name = model.Name;
                        string email = model.Email;
                        string IC = model.IC;
                        string phoneNo = model.PhoneNo;

                        SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM [crm_customer] WHERE ([nric] = @IC)", con);
                        
                        check_User_Name.Parameters.AddWithValue("@IC", IC.ToString());
                        int UserExist = (int)check_User_Name.ExecuteScalar();

                        if (UserExist > 0)
                        {
                            //PLUSMILES MEMBER
                            DateTime dateTime = DateTime.UtcNow.Date;
                            string Timestamp = dateTime.ToString("dd/MM/yyyy");
                            string currentTime = DateTime.Now.ToString("h:mm:ss tt");
                            string query = "INSERT INTO [lylty_contest] (EMAIL, NAME, FESTIVE, IC_NO, PHONE_NO, DateKeyIn, TimeKeyIn) VALUES (@Email, @Name, 'RAYA2019', @IC, @Phone_No, @DateKeyIn, @Time)";
                            query += " SELECT SCOPE_IDENTITY()";
                            using (SqlCommand cmd = new SqlCommand(query))
                            {
                                cmd.Connection = con;

                                cmd.Parameters.AddWithValue("@Email", model.Email);
                                cmd.Parameters.AddWithValue("@Name", model.Name);
                                cmd.Parameters.AddWithValue("@IC", model.IC);
                                cmd.Parameters.AddWithValue("@Phone_No", model.PhoneNo);
                                cmd.Parameters.AddWithValue("@DateKeyIn", Timestamp);
                                cmd.Parameters.AddWithValue("@Time", currentTime);
                                cmd.ExecuteScalar();
                                con.Close();
                            }
                            ViewBag.Message = string.Format("Submission complete! Youre a PLUSMiles Member");
                            return View();
                        }
                        else
                        {
                            ViewBag.Message = string.Format("Submission fail! Kindly register at www.plusmiles.com.my or contact 1800-88-0000");
                            return View();
                            //NOT PLUSMILES MEMBER
                        }

                    }
                }
                catch (Exception ex)
                {
                    return View();
                }

            }
            else
            {
                ViewBag.Message = string.Format("Please fill up all the required field! ");
                return View();
            }
        }

        public ActionResult Redeem()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Redeem(RedeemModel model)
        {
            if (model.Email != null && model.Name != null && model.Location != null)
            {
                try
                {
                    string constr = WebConfigurationManager.AppSettings["DBConString"];
                    //"Server=tcp:festive.database.windows.net,1433;Initial Catalog=FestiveDB_staging;Persist Security Info=False;User ID=admin_festive;Password=P@55w0rd2018;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                    using (SqlConnection con = new SqlConnection(constr))
                    {
                        con.Open(); // throws if invalid

                        string name = model.Name;
                        string email = model.Email;
                        string loc = model.Location;

                        SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM [USERREDEEM] WHERE ([EMAIL] = @email)", con);
                        check_User_Name.Parameters.AddWithValue("@email", email.ToString());
                        int UserExist = (int)check_User_Name.ExecuteScalar();

                        if (UserExist > 0)
                        {
                            ViewBag.Message = string.Format("You already redeem");
                            return View();
                            //Username exist
                        }
                        else
                        {
                            //Username has not redeem yet
                            DateTime dateTime = DateTime.UtcNow.Date;
                            string Timestamp = dateTime.ToString("dd/MM/yyyy");
                            string currentTime = DateTime.Now.ToString("h:mm:ss tt");
                            string query = "INSERT INTO [USERREDEEM] (EMAIL, NAME, FESTIVE, LOC, DateKeyIn, TimeKeyIn) VALUES (@Email, @Name, 'RAYA2019', @Loc, @DateKeyIn, @Time)";
                            query += " SELECT SCOPE_IDENTITY()";
                            using (SqlCommand cmd = new SqlCommand(query))
                            {
                                cmd.Connection = con;

                                cmd.Parameters.AddWithValue("@Email", model.Email);
                                cmd.Parameters.AddWithValue("@Name", model.Name);
                                cmd.Parameters.AddWithValue("@Loc", model.Location);
                                cmd.Parameters.AddWithValue("@DateKeyIn", Timestamp);
                                cmd.Parameters.AddWithValue("@Time", currentTime);
                                cmd.ExecuteScalar();
                                con.Close();
                            }
                            return RedirectToAction("SafeDrive");
                        }
                        
                    }
                }
                catch (Exception ex)
                {
                    return View();
                }
                
            }
            else
            {
                ViewBag.Message = string.Format("Please fill up all the required field! ");
                return View();
            }
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
                            "    <img src=\"https://plusjourney.azurewebsites.net/images/bnr_1024px_b.jpg \" style=\"width:100%; align:center;\">" +
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Index(DriverModel model)
        {
            if (model.Email != null)
            {
                #region Save Driver Info to Database
                string constr = "Server=tcp:festive.database.windows.net,1433;Initial Catalog=FestiveDB_staging;Persist Security Info=False;User ID=admin_festive;Password=P@55w0rd2018;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    try
                    {
                        conn.Open(); // throws if invalid
                        using (SqlConnection con = new SqlConnection(constr))
                        {
                            DateTime dateTime = DateTime.UtcNow.Date;
                            string Timestamp = dateTime.ToString("dd/MM/yyyy");
                            string query = "INSERT INTO Driver (Email, LocFrom, LocTo, DepartDate, DepartTime, DateKeyIn, FESTIVE) VALUES (@Email, @From, @To, @Date, @Time, @DateKeyIn, 'RAYA2019')";
                            query += " SELECT SCOPE_IDENTITY()";
                            using (SqlCommand cmd = new SqlCommand(query))
                            {
                                cmd.Connection = con;
                                con.Open();

                                cmd.Parameters.AddWithValue("@Email", model.Email);
                                cmd.Parameters.AddWithValue("@From", model.FromTextBox);
                                cmd.Parameters.AddWithValue("@To", model.ToTextBox);
                                cmd.Parameters.AddWithValue("@Date", model.DateSelected);
                                cmd.Parameters.AddWithValue("@Time", model.Time);
                                cmd.Parameters.AddWithValue("@DateKeyIn", Timestamp);
                                cmd.ExecuteScalar();
                                con.Close();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errMsg = ex.ToString();
                        return View("Error");
                    }

                }
                #endregion

                #region Sent Email to Driver
                if (ModelState.IsValid)
                {
                    var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                    var message = new MailMessage();
                    message.To.Add(new MailAddress(model.Email));  // replace with valid value 
                    message.From = new MailAddress("plusmiles@plus.uemnet.com");  // replace with valid value
                    message.Subject = "Thank you for planning your Raya trip with PLUS";
                    message.Body = string.Format(body, model.From, model.Email, model.lblFromTo);
                    message.IsBodyHtml = true;

                    string htmlBody;

                    string from = model.FromTextBox.ToString();
                    string to = model.ToTextBox.ToString();
                    string date = model.DateSelected;
                    string time = model.Time;

                    string GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190130T230000Z%2F20190130T230000Z&text=Chinese%20New%20Year%20Trip";

                    if (time == "7:00 am")
                    {
                        if (date == "29 May")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190528T230000Z%2F20190528T230000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "30 May")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190529T230000Z%2F20190529T230000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "31 May")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190530T230000Z%2F20190529T230000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "1 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190531T230000Z%2F20190531T230000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "2 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190601T230000Z%2F20190601T230000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "3 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190602T230000Z%2F20190602T230000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "5 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190604T230000Z%2F20190604T230000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "6 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190605T230000Z%2F20190605T230000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "7 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190606T230000Z%2F20190606T230000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "8 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190607T230000Z%2F20190607T230000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "9 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190608T230000Z%2F20190608T230000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "10 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190609T230000Z%2F20190609T230000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                    }
                    else if (time == "11:00 am")
                    {
                        if (date == "29 May")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190529T030000Z%2F20190529T030000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "30 May")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190530T030000Z%2F20190530T030000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "31 May")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190531T030000Z%2F20190531T030000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "1 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190601T030000Z%2F201900601T030000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "2 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190602T030000Z%2F20190602T030000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "3 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190603T030000Z%2F20190603T030000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "5 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190605T030000Z%2F20190605T030000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "6 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190606T030000Z%2F20190606T030000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "7 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190607T030000Z%2F20190607T030000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "8 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190608T030000Z%2F20190608T030000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "9 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190609T030000Z%2F20190609T030000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "10 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190610T030000Z%2F20190610T030000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                    }
                    else if (time == "3:00 pm")
                    {
                        if (date == "29 May")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190529T070000Z%2F20190529T070000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "30 May")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190530T070000Z%2F20190530T070000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "31 May")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190531T070000Z%2F20190531T070000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "1 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190601T070000Z%2F20190601T070000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "2 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190602T070000Z%2F20190602T070000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "3 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190603T070000Z%2F20190603T070000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "5 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190605T070000Z%2F20190605T070000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "6 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190606T070000Z%2F20190606T070000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "7 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190607T070000Z%2F20190607T070000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "8 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190608T070000Z%2F20190608T070000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "9 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190609T070000Z%2F20190609T070000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "10 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190610T070000Z%2F20190610T070000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                    }
                    else if (time == "7:00 pm")
                    {
                        if (date == "29 May")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190529T110000Z%2F20190529T110000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "30 May")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190530T110000Z%2F20190530T110000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "31 May")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190531T110000Z%2F20190531T110000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "1 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190601T110000Z%2F20190601T110000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "2 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190602T110000Z%2F20190602T110000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "3 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190603T110000Z%2F20190603T110000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "5 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190605T110000Z%2F20190605T110000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "6 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190606T110000Z%2F20190606T110000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "7 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190607T110000Z%2F20190607T110000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "8 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190608T110000Z%2F20190608T110000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "9 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190609T110000Z%2F20190609T110000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                        else if (date == "10 June")
                        { GoogleCalendarLink = "http://www.google.com/calendar/event?action=TEMPLATE&dates=20190610T110000Z%2F20190610T110000Z&text=Balik%20Beraya%20Bersama%20PLUS"; }
                    }
                    else { GoogleCalendarLink = ""; }

                    htmlBody = "<body bgcolor=\"#eaeaea\">" +
                                "<table width=\"100%\" align=\"center\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" bgcolor=\"#ffffff\">" +
                                "<tbody>" +
                                "<tr>" +
                                "<td>" +
                                "<img src=\"https://plusjourney.azurewebsites.net/images/Raya_Bannerforemail1366x420.jpg \" alt=\"More miles more smiles with PLUSMiles\" width=\"100%\" align=\"center\"/>" +
                                "<p style=\"font-family: Helvetica, Arial, sans-serif; font-size: 25px; color: #006738; line-height: 60px; padding-left: 20px; margin-top: 10px; padding-right: 20px;\" align=\"center\"><strong>TRAVEL ITINERARY</strong></p>" +
                                "<p style=\"font-family: Helvetica, Arial, sans-serif; font-size: 14px; line-height: 20px; color: #000000; padding-left: 20px; margin-top: -30px; padding-right: 20px; padding-bottom:10px;\" align=\"center\">Thank you for planning your Hari Raya trip with us, below is your recommended date and time for you to start your journey to your destination.</p>" +
                                "</td>" +
                                "</tr>" +
                                "</tbody>" +
                                "</table>" +
                                "<table width=\"100%\" align=\"center\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" bgcolor=\"#FFFFFF\">" +
                                "<tbody>" +
                                "<tr>" +
                                "<td align=\"center\">" +
                                "<p style=\"font-family: Helvetica, Arial, sans-serif; font-size: 20px; color: #0033A1; padding-left: 20px; margin-top: 10px; padding-right: 20px; padding-bottom:10px;\" align=\"center\"><strong>" + from.ToString() + " - " + to.ToString() + "</strong></p>" +
                                "<p style=\"font-family: Helvetica, Arial, sans-serif; font-size: 16px; color: #000000; padding-left: 20px; margin-top: -20px; padding-right: 20px; padding-bottom:10px;\" align=\"center\"><strong>" + date.ToString() + " 2019 -" + " " + time.ToString() + " </strong></p>" +
                                "</td>" +
                                "</tr>" +
                                "</tbody>" +
                                "</table>" +
                                "<table width=\"100%\" align=\"center\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" bgcolor=\"#FFFFFF\">" +
                                "<tbody>" +
                                "<tr>" +
                                "<td align=\"center\">" +
                                "<p style=\"font-family: Helvetica, Arial, sans-serif; font-size: 16px; color: #c82039; padding-left: 20px; margin-top: 10px; padding-right: 20px; padding-bottom:20px;\" align=\"center\"><a href=" + GoogleCalendarLink.ToString() + "><img src=\"https://plusjourney.azurewebsites.net/images/btn_savethedate.jpg\" width=\"200\" alt=\"Update Profile Button\"/></a></p>" +
                                "<p style=\"font-family: Helvetica, Arial, sans-serif; font-size: 16px; color: #c82039; padding-left: 20px; margin-top: 10px; padding-right: 20px; padding-bottom:20px;\" align=\"center\"></p>" +
                                "</td>" +
                                "</tr>" +
                                "</tbody>" +
                                "</table>" +
                                "<table width=\"100%\" align=\"center\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" bgcolor=\"#006738\">" +
                                "          <tr><td><br /></td></tr> <tr>" +
                                "            <td width=\"100%\" valign=\"top\"><img src=\"https://plusjourney.azurewebsites.net/images/BuahTanganEmail.jpg \" width=\"100%\" alt=\"Buah Tangan Bag\" /></td>" +
                                "            <td align=\"left\" valign=\"top\">" +
                                " </td>" +
                                "          </tr>" +
                                "        </table>" +
                                "" +
                                "<!-- 4 Columns -->" +
                                "" +
                                "<table width=\"100%\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" align=\"center\" bgcolor=\"#363636\">" +
                                "  <tr>" +
                                "  <td>" +
                                "  <table width=\"90%\" border=\"0\" cellpadding=\"10\" cellspacing=\"0\" align=\"center\" style=\"margin:0 auto;\">" +
                                "  <tr>" +
                                "  <td>" +
                                "  <table width=\"60%\" cellpadding=\"0\" cellspacing=\"0\"  border=\"0\" align=\"left\">" +
                                "  <tr>" +
                                "  <td valign=\"top\" style=\"font-size: 11px; color: #f1f1f1; color:#999; font-family: Arial, sans-serif; padding-bottom:20px\" class=\"center\">" +
                                "Disclaimer: Our travel time advisory above is based on the traffic insights during Chinese New Year period for the past 5 years." +
                                "  <br/><br/>" +
                                "PLUS Malaysia Berhad (923639-A)" +
                                "  <a href=\"http://www.plus.com.my\" style=\"color:#999;text-decoration:underline;\">www.plus.com.my</a>" +
                                "  </td>" +
                                "</tr>" +
                                "<tr>" +
                                "  <td valign=\"center\" style=\"font-size: 11px; color: #f1f1f1; color:#999; font-family: Arial, sans-serif; padding-bottom:5px\" class=\"center\">" +
                                "  <img src=\"https://plusjourney.azurewebsites.net/images/plus_app_thumb.png \" width=\"18\"> Download PLUS App: <a href=\"https://itunes.apple.com/my/app/plus-app-official/id1439887531?mt=8\" style=\"color:#999;text-decoration:underline;\">iOS</a>&nbsp; | &nbsp;<a href=\"https://play.google.com/store/apps/details?id=com.PLUS&showAllReviews=true\" style=\"color:#999;text-decoration:underline;\">Android</a> </p>" +
                                "  </td>" +
                                "</tr>" +
                                "  </table>" +
                                "" +
                                "  <table width=\"30%\" cellpadding=\"0\" cellspacing=\"0\"  border=\"0\" align=\"right\" class=\"deviceWidth\">" +
                                "  <tr>" +
                                "  <td valign=\"top\" style=\"font-size: 11px; color: #f1f1f1; font-weight: normal; font-family: Georgia, Times, serif; line-height: 26px; vertical-align: top; text-align:right\" class=\"center\">" +
                                "  <a href=\"https://www.facebook.com/MYPLUSMiles\" target=\"_blank\"><img src=\"https://plusjourney.azurewebsites.net/images/facebook.png \" width=\"30\" height=\"30\" alt=\"Facebook\" title=\"Facebook\" border=\"0\" /></a>" +
                                "  <a href=\"https://www.instagram.com/plus_malaysia/\" target=\"_blank\"><img src=\"https://plusjourney.azurewebsites.net/images/instagram.png \" width=\"30\" height=\"30\" alt=\"Instagram\" title=\"Instagram\" border=\"0\" /></a>" +
                                "  <a href=\"https://twitter.com/plus2u\" target=\"_blank\"><img src=\"https://plusjourney.azurewebsites.net/images/twitter.png \" width=\"30\" height=\"30\" alt=\"Twitter\" title=\"Twitter\" border=\"0\" /></a>" +
                                "  </br>" +
                                "  <a href=\"http://www.plus.com.my\"><img src=\"https://plusjourney.azurewebsites.net/images/plus_logo.png \" alt=\"\" border=\"0\" width=\"70\" style=\"padding-top: 5px;\" /></a><br/>" +
                                "  </td>" +
                                "  </tr>" +
                                "  </table>" +
                                "  </td>" +
                                "  </tr>" +
                                "  </table>" +
                                "    </td>" +
                                "  </tr>" +
                                "</table><!-- End 4 Columns -->" +
                                "<table width=\"100%\" align=\"center\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" bgcolor=\"#ffffff\">" +
                                "<tbody>" +
                                "<tr>" +
                                "<td>" +
                                "<img src=\"https://plusjourney.azurewebsites.net/images/footer_bar.jpg \" alt=\"More miles more smiles with PLUSMiles\" width=\"100%\" align=\"center\"/>" +
                                "</td>" +
                                "</tr>" +
                                "</tbody>" +
                                "</table>" +
                                "</body>";

                    message.Body = htmlBody;

                    Task.Run(async () =>
                    {
                        using (var smtp = new SmtpClient())
                        {
                            var credential = new NetworkCredential
                            {
                                UserName = "plusmiles@plus.uemnet.com",  // replace with valid value
                                Password = "Plus1234"  // replace with valid value
                            };
                            smtp.Credentials = credential;
                            smtp.Host = "smtp-mail.outlook.com";
                            smtp.Port = 587;
                            smtp.EnableSsl = true;
                            await smtp.SendMailAsync(message);
                            //return RedirectToAction("ThankYou");
                        }
                    });
                    return RedirectToAction("ThankYou");
                }
                #endregion
                return RedirectToAction("ThankYou");
            }
            else
            {
                return View(model);
            }
        }
    }
}