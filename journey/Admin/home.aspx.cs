using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
using System.Security.Permissions;
using System.Windows.Forms;
using System.Web.Configuration;

namespace journey.Admin
{
    public partial class home : System.Web.UI.Page
    {
        //public int jan31, feb1, feb2, feb7, feb8, feb9;
        public int csDay1, csDay2, csDay3, csDay4, csDay5, csDay6, csDay7, csDay8, csDay9, csDay10, csDay11, csDay12;

        public string csProName1, csProName2, csProName3, csProName4, csProName5, csProName6, csProName7, csProName8, csProName9, csProName10;
        public string csProName11, csProName12, csProName13, csProName14, csProName15, csProName16, csProName17, csProName18, csProName19, csProName20;

        public string csProCount1, csProCount2, csProCount3, csProCount4, csProCount5, csProCount6, csProCount7, csProCount8, csProCount9, csProCount10;
        public string csProCount11, csProCount12, csProCount13, csProCount14, csProCount15, csProCount16, csProCount17, csProCount18, csProCount19, csProCount20;

        public int jutebag, sunshade;

        public int dunkin_donut, umbrella, towel, tumbler, nasikambing, rotibakar, kreme;

        
        protected void lnkbtnExCSV_Click(object sender, EventArgs e)
        {
                //select folder to save csv

                SqlConnection sqlCon = new SqlConnection(WebConfigurationManager.AppSettings["DBConString"]);
                sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand(
                    "Select * from DRIVER", sqlCon);
                SqlDataReader reader = sqlCmd.ExecuteReader();

                string fileName = "D:/Users/ifwat.ibrahim/Desktop/Download CSV/journeyDriver.csv";
                StreamWriter sw = new StreamWriter(fileName);
                object[] output = new object[reader.FieldCount];

                for (int i = 0; i < reader.FieldCount; i++)
                    output[i] = reader.GetName(i);

                sw.WriteLine(string.Join(",", output));

                while (reader.Read())
                {
                    reader.GetValues(output);
                    sw.WriteLine(string.Join(",", output));
                }

                sw.Close();
                reader.Close();
                sqlCon.Close();
          
        }

        [STAThread]
        protected void Page_Load(object sender, EventArgs e)
        {
            string constrForProd = WebConfigurationManager.AppSettings["DBConStringLMSLoyaltyPROD"];

            #region Load 10 products name into LIST
            using (SqlConnection con = new SqlConnection(constrForProd))
            {
                string sqlItemName = "" +
"SELECT TOP 20 product_name, COUNT(sku) as 'Item Redeem'" +
"FROM[fulfill_order] where category_code = 'M01' and " +
"created_timestamp NOT LIKE '2019-05-23%' and " +
"created_timestamp NOT LIKE '2019-05-22%' and " +
"created_timestamp NOT LIKE '2019-05-21%' and " +
"created_timestamp NOT LIKE '2019-05-20%' and " +
"created_timestamp NOT LIKE '2019-05-19%' and " +
"created_timestamp NOT LIKE '2019-05-18%' and " +
"created_timestamp NOT LIKE '2019-05-17%' and " +
"created_timestamp NOT LIKE '2019-05-18%' and " +
"created_timestamp NOT LIKE '2019-05-16%' and " +
"created_timestamp NOT LIKE '2019-05-15%' " +
"GROUP BY product_name order by 'Item Redeem' desc";
                //"SELECT TOP 10 product_name, COUNT(sku) as 'Item Redeem' " +
                //"FROM[fulfill_order] where category_code = 'M01' " +
                //"GROUP BY product_name order by 'Item Redeem' desc";
                SqlCommand comm = new SqlCommand(sqlItemName, con);
                con.Open();

                SqlDataReader reader = comm.ExecuteReader();
                List<string> str = new List<string>();
                int i = 0;
                while (reader.Read())
                {
                    str.Add(reader.GetValue(0).ToString());
                }
                csProName1 = str[0].ToString();
                csProName2 = str[1].ToString();
                csProName3 = str[2].ToString();
                csProName4 = str[3].ToString();
                csProName5 = str[4].ToString();
                csProName6 = str[5].ToString();
                csProName7 = str[6].ToString();
                csProName8 = str[7].ToString();
                csProName9 = str[8].ToString();
                csProName10 = str[9].ToString();
                csProName11 = str[10].ToString();
                csProName12 = str[11].ToString();
                csProName13 = str[12].ToString();
                csProName14 = str[13].ToString();
                csProName15 = str[14].ToString();
                csProName16 = str[15].ToString();

                //csProName17 = str[16].ToString();
                //csProName18 = str[17].ToString();
                //csProName19 = str[18].ToString();
                //csProName20 = str[19].ToString();
                reader.Close();
            }
            #endregion
            #region Load Top 10 products count into LIST
            using (SqlConnection con = new SqlConnection(constrForProd))
            {
                string sqlItemName = ""+
"SELECT TOP 20 COUNT(sku) as 'Item Redeem', product_name " +
"FROM[fulfill_order] where category_code = 'M01' and " +
"created_timestamp NOT LIKE '2019-05-23%' and " +
"created_timestamp NOT LIKE '2019-05-22%' and " +
"created_timestamp NOT LIKE '2019-05-21%' and " +
"created_timestamp NOT LIKE '2019-05-20%' and " +
"created_timestamp NOT LIKE '2019-05-19%' and " +
"created_timestamp NOT LIKE '2019-05-18%' and " +
"created_timestamp NOT LIKE '2019-05-17%' and " +
"created_timestamp NOT LIKE '2019-05-18%' and " +
"created_timestamp NOT LIKE '2019-05-16%' and " +
"created_timestamp NOT LIKE '2019-05-15%' " +
"GROUP BY product_name order by 'Item Redeem' desc";
                    
                    //"SELECT TOP 10 COUNT(sku) as 'Item Redeem', product_name " +
                    //"FROM[fulfill_order] where category_code = 'M01' " +
                    //"GROUP BY product_name order by 'Item Redeem' desc";
                SqlCommand comm = new SqlCommand(sqlItemName, con);
                con.Open();

                SqlDataReader reader = comm.ExecuteReader();
                List<string> countPro = new List<string>();
                int i = 0;
                while (reader.Read())
                {
                    countPro.Add(reader.GetValue(0).ToString());
                }
                csProCount1 = countPro[0].ToString();
                csProCount2 = countPro[1].ToString();
                csProCount3 = countPro[2].ToString();
                csProCount4 = countPro[3].ToString();
                csProCount5 = countPro[4].ToString();
                csProCount6 = countPro[5].ToString();
                csProCount7 = countPro[6].ToString();
                csProCount8 = countPro[7].ToString();
                csProCount9 = countPro[8].ToString();
                csProCount10 = countPro[9].ToString();
                csProCount11 = countPro[10].ToString();
                csProCount12 = countPro[11].ToString();
                csProCount13 = countPro[12].ToString();
                csProCount14 = countPro[13].ToString();
                csProCount15 = countPro[14].ToString();
                csProCount16 = countPro[15].ToString();
                //csProCount17 = countPro[16].ToString();
                //csProCount18 = countPro[17].ToString();
                //csProCount19 = countPro[18].ToString();
                //csProCount20 = countPro[19].ToString();
                reader.Close();
            }
            #endregion

            using (SqlConnection con = new SqlConnection(constrForProd))
            {
                #region Display Balance Point by Products
                con.Open();
                SqlCommand cmdBalPoint = new SqlCommand("select product_name as 'Product', stock_available as 'Balance' from [dbo].[ctlog_product_inventory] where root_category_id = '25' order by stock_available asc", con);
                SqlDataReader drBalPoint = cmdBalPoint.ExecuteReader();
                gvBalPoint.DataSource = drBalPoint;
                gvBalPoint.DataBind();
                con.Close();
                #endregion
            }

            using (SqlConnection con = new SqlConnection(WebConfigurationManager.AppSettings["DBConString"]))
            {
                #region COUNT BAG REDEEM
                con.Open();
                // FOR RECENT ITEM REDEEM - string sqlQuery = "select top 20 sku as 'ID', product_name as 'Items', created_timestamp as 'Redeem Time' from [dbo].[fulfill_order] where category_code = 'M01' order by created_timestamp desc";
                string sqlQuery1 = "SELECT  Loc as 'Location', COUNT(id) as 'Redeem'" +
                "FROM [USERREDEEM] where item = 'sunshade'" +
                "GROUP BY Loc";
                SqlCommand cmdRecentRedeem = new SqlCommand(sqlQuery1, con);
                SqlDataReader drRecentRedeem = cmdRecentRedeem.ExecuteReader();
                gvRecentItemRedeem.DataSource = drRecentRedeem;
                gvRecentItemRedeem.DataBind();
                con.Close();
                #endregion

                #region COUNT BAG REDEEM
                con.Open();
                //string sqlQuery = "SELECT LOC as 'LOCATION' , COUNT(ID) as 'BAG REDEEMED'  FROM [USERREDEEM] GROUP BY LOC ORDER BY 'BAG REDEEMED' DESC";
                string sqlQuery = "SELECT  Loc as 'Location', COUNT(id) as 'Redeem'" +
                "FROM [USERREDEEM] where item = 'jute bag'" +
                "GROUP BY Loc";
                SqlCommand cmdBagRedeem = new SqlCommand(sqlQuery, con);
                SqlDataReader drRedeemBag = cmdBagRedeem.ExecuteReader();
                gvBagRedeem.DataSource = drRedeemBag;
                gvBagRedeem.DataBind();
                con.Close();
                #endregion

                #region Select Highest User
                //con.Open();
                //SqlCommand cmdHighUser = new SqlCommand("select top 10 username as 'Customer Name', point as 'Point Spend' from redemption order by point desc", con);
                //SqlDataReader drHighUser = cmdHighUser.ExecuteReader();
                //gvHighestUser.DataSource = drHighUser;
                //gvHighestUser.DataBind();
                //con.Close();
                #endregion
            }

            using (SqlConnection con = new SqlConnection(WebConfigurationManager.AppSettings["DBConString"]))
            {
                #region Count PRE Date selection
                con.Open();
                String sqlDay1 = "SELECT COUNT(ID) AS '29 May' FROM DRIVER WHERE DEPARTDATE = '29 May' or DEPARTDATE = '29-may'";
                SqlCommand cmdDay1 = new SqlCommand(sqlDay1, con);
                Int32 countDay1 = (Int32)cmdDay1.ExecuteScalar();
                csDay1 = countDay1;
                con.Close();

                con.Open();
                String sqlDay2 = "SELECT COUNT(ID) AS '30 May' FROM DRIVER WHERE DEPARTDATE = '30 May' or DEPARTDATE = '30-may'";
                SqlCommand cmdDay2 = new SqlCommand(sqlDay2, con);
                Int32 countDay2 = (Int32)cmdDay2.ExecuteScalar();
                csDay2 = countDay2;
                con.Close();

                con.Open();
                String sqlDay3 = "SELECT COUNT(ID) AS '31 May' FROM DRIVER WHERE DEPARTDATE = '31 May' or DEPARTDATE = '31-may'";
                SqlCommand cmdDay3 = new SqlCommand(sqlDay3, con);
                Int32 countDay3 = (Int32)cmdDay3.ExecuteScalar();
                csDay3 = countDay3;
                con.Close();

                con.Open();
                String sqlDay4 = "SELECT COUNT(ID) AS '1 June' FROM DRIVER WHERE DEPARTDATE = '1 June' or DEPARTDATE = '1-June'";
                SqlCommand cmdDay4 = new SqlCommand(sqlDay4, con);
                Int32 countDay4 = (Int32)cmdDay4.ExecuteScalar();
                csDay4 = countDay4;
                con.Close();

                con.Open();
                String sqlDay5 = "SELECT COUNT(ID) AS '2 June' FROM DRIVER WHERE DEPARTDATE = '2 June' or DEPARTDATE = '2-June'";
                SqlCommand cmdDay5 = new SqlCommand(sqlDay5, con);
                Int32 countDay5 = (Int32)cmdDay5.ExecuteScalar();
                csDay5 = countDay5;
                con.Close();

                con.Open();
                String sqlDay6 = "SELECT COUNT(ID) AS '3 June' FROM DRIVER WHERE DEPARTDATE = '3 June' or DEPARTDATE = '3-June'";
                SqlCommand cmdDay6 = new SqlCommand(sqlDay6, con);
                Int32 countDay6 = (Int32)cmdDay6.ExecuteScalar();
                csDay6 = countDay6;
                con.Close();
                #endregion

                #region Count POST Date selection
                con.Open();
                String sqlDay7 = "SELECT COUNT(ID) AS '5 June' FROM DRIVER WHERE DEPARTDATE = '5 June' or DEPARTDATE = '5-june'";
                SqlCommand cmdDay7 = new SqlCommand(sqlDay7, con);
                Int32 countDay7 = (Int32)cmdDay7.ExecuteScalar();
                csDay7 = countDay7;
                con.Close();

                con.Open();
                String sqlDay8 = "SELECT COUNT(ID) AS '6 June' FROM DRIVER WHERE DEPARTDATE = '6 June' or DEPARTDATE = '6-june'";
                SqlCommand cmdDay8 = new SqlCommand(sqlDay8, con);
                Int32 countDay8 = (Int32)cmdDay8.ExecuteScalar();
                csDay8 = countDay8;
                con.Close();

                con.Open();
                String sqlDay9 = "SELECT COUNT(ID) AS '7 June' FROM DRIVER WHERE DEPARTDATE = '7 June' or DEPARTDATE = '7-june'";
                SqlCommand cmdDay9 = new SqlCommand(sqlDay9, con);
                Int32 countDay9 = (Int32)cmdDay9.ExecuteScalar();
                csDay9 = countDay9;
                con.Close();

                con.Open();
                String sqlDay10 = "SELECT COUNT(ID) AS '8 June' FROM DRIVER WHERE DEPARTDATE = '8 June' or DEPARTDATE = '8-June'";
                SqlCommand cmdDay10 = new SqlCommand(sqlDay10, con);
                Int32 countDay10 = (Int32)cmdDay10.ExecuteScalar();
                csDay10 = countDay10;
                con.Close();

                con.Open();
                String sqlDay11 = "SELECT COUNT(ID) AS '9 June' FROM DRIVER WHERE DEPARTDATE = '9 June' or DEPARTDATE = '9-June'";
                SqlCommand cmdDay11 = new SqlCommand(sqlDay11, con);
                Int32 countDay11 = (Int32)cmdDay11.ExecuteScalar();
                csDay11 = countDay11;
                con.Close();

                con.Open();
                String sqlDay12 = "SELECT COUNT(ID) AS '10 June' FROM DRIVER WHERE DEPARTDATE = '10 June' or DEPARTDATE = '10-June'";
                SqlCommand cmdDay12 = new SqlCommand(sqlDay12, con);
                Int32 countDay12 = (Int32)cmdDay12.ExecuteScalar();
                csDay12 = countDay12;
                con.Close();
                #endregion

                #region Count Total Jute Bag
                con.Open();
                String sqlCountJuteBag = "select count(id) from USERREDEEM where item = 'jute bag'";
                SqlCommand cmdJuteBag = new SqlCommand(sqlCountJuteBag, con);
                Int32 countJuteBag = (Int32)cmdJuteBag.ExecuteScalar();
                lblJuteBagCount.Text = countJuteBag.ToString();
                con.Close();
                #endregion

                #region Count Total SunShade
                con.Open();
                String sqlCountSunShade = "select count(id) from USERREDEEM where item = 'sunshade'";
                SqlCommand cmdCountSunshade = new SqlCommand(sqlCountSunShade, con);
                Int32 countSunshade = (Int32)cmdCountSunshade.ExecuteScalar();
                lblSunShadeCount.Text = countSunshade.ToString();
                con.Close();
                #endregion
            }

            GridviewBind();
        }

        protected void GridviewBind()
        {
            using (SqlConnection con = new SqlConnection(WebConfigurationManager.AppSettings["DBConString"]))
            {
                #region display email list
                con.Open();
                SqlCommand cmd = new SqlCommand("Select EMAIL FROM DRIVER where FESTIVE = 'RAYA2019'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                //GridView1.PageIndex = e.NewPageIndex;
                GridView1.DataSource = dr;
                GridView1.DataBind();
                con.Close();
                #endregion

                #region count total driver
                con.Open();
                String sqlCount = "SELECT COUNT(ID) as DRIVER FROM DRIVER where FESTIVE = 'RAYA2019'";
                SqlCommand cmdCount = new SqlCommand(sqlCount, con);
                Int32 count = (Int32)cmdCount.ExecuteScalar();
                lblTotalSubscribers.Text = count.ToString();
                con.Close();
                #endregion

                #region most top 10 driver from
                con.Open();
                SqlCommand cmdMostFrom = new SqlCommand("select top 10 locfrom as 'Driver From', count(*) Total from driver  where FESTIVE = 'RAYA2019' group by locfrom order by Total desc", con);
                SqlDataReader drMostFrom = cmdMostFrom.ExecuteReader();
                gvMostFrom.DataSource = drMostFrom;
                gvMostFrom.DataBind();
                con.Close();
                #endregion

                #region most top 10 driver to
                con.Open();
                SqlCommand cmdMostTo = new SqlCommand("select top 10 locto as 'Driver To', count(*) Total from driver  where FESTIVE = 'RAYA2019' group by locto order by Total desc", con);
                SqlDataReader drMostTo = cmdMostTo.ExecuteReader();
                gvMostTo.DataSource = drMostTo;
                gvMostTo.DataBind();
                con.Close();
                #endregion

                #region most user subscribe on
                con.Open();
                SqlCommand cmdMostSubscribe = new SqlCommand("select DateKeyIn as 'Date', COUNT(ID) as 'User Subscribed' from driver  where FESTIVE = 'RAYA2019' GROUP BY DateKeyIn order by convert(datetime, DateKeyIn, 103) desc", con);
                SqlDataReader drMostSubscribe = cmdMostSubscribe.ExecuteReader();
                gvMostUserSubscribe.DataSource = drMostSubscribe;
                gvMostUserSubscribe.DataBind();
                con.Close();
                #endregion

            }
        }
    }
}