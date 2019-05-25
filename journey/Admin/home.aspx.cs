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
        public int jan31, feb1, feb2, feb7, feb8, feb9;
        public int dunkin_donut, umbrella, towel, tumbler, nasikambing, rotibakar, kreme;

        
        protected void lnkbtnExCSV_Click(object sender, EventArgs e)
        {
                //select folder to save csv

                SqlConnection sqlCon = new SqlConnection("Server=tcp:festive.database.windows.net,1433;Initial Catalog=FestiveDB;Persist Security Info=False;User ID=admin_festive;Password=P@55w0rd2018;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
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
            using (SqlConnection con = new SqlConnection(constrForProd))
            {
                #region COUNT BAG REDEEM
                con.Open();
                string sqlQuery = "select top 10 sku, product_name from [dbo].[fulfill_order] where category_code = 'M01' order by created_timestamp desc";
                SqlCommand cmdRecentRedeem = new SqlCommand(sqlQuery, con);
                SqlDataReader drRecentRedeem = cmdRecentRedeem.ExecuteReader();
                gvRecentItemRedeem.DataSource = drRecentRedeem;
                gvRecentItemRedeem.DataBind();
                con.Close();
                #endregion

                #region Display Balance Point by Products
                con.Open();
                SqlCommand cmdBalPoint = new SqlCommand("select sku, product_name, stock_available from [dbo].[ctlog_product_inventory] where root_category_id = '25' order by stock_available desc", con);
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
                string sqlQuery = "SELECT LOC as 'LOCATION' , COUNT(ID) as 'BAG REDEEMED'  FROM [USERREDEEM] GROUP BY LOC ORDER BY 'BAG REDEEMED' DESC";
                SqlCommand cmdBagRedeem = new SqlCommand(sqlQuery, con);
                SqlDataReader drRedeemBag = cmdBagRedeem.ExecuteReader();
                gvBagRedeem.DataSource = drRedeemBag;
                gvBagRedeem.DataBind();
                con.Close();
                #endregion

                #region Select Highest User
                con.Open();
                SqlCommand cmdHighUser = new SqlCommand("select top 10 username as 'Customer Name', point as 'Point Spend' from redemption order by point desc", con);
                SqlDataReader drHighUser = cmdHighUser.ExecuteReader();
                gvHighestUser.DataSource = drHighUser;
                gvHighestUser.DataBind();
                con.Close();
                #endregion
            }

            using (SqlConnection con = new SqlConnection("Server=tcp:festive.database.windows.net,1433;Initial Catalog=FestiveDB;Persist Security Info=False;User ID=admin_festive;Password=P@55w0rd2018;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                #region Count Date selection
                con.Open();
                String sql31jan = "SELECT COUNT(ID) AS '31 JAN' FROM DRIVER WHERE DEPARTDATE = '31 Jan' or DEPARTDATE = '31-jan'";
                SqlCommand cmd31jan = new SqlCommand(sql31jan, con);
                Int32 count31 = (Int32)cmd31jan.ExecuteScalar();
                jan31 = count31;
                con.Close();

                con.Open();
                String sql1feb = "SELECT COUNT(ID) AS '1 FEB' FROM DRIVER WHERE DEPARTDATE = '1 FEB' or DEPARTDATE = '1-feb'";
                SqlCommand cmd1feb = new SqlCommand(sql1feb, con);
                Int32 count1feb = (Int32)cmd1feb.ExecuteScalar();
                feb1 = count1feb;
                con.Close();

                con.Open();
                String sql2feb = "SELECT COUNT(ID) AS '2 FEB' FROM DRIVER WHERE DEPARTDATE = '2 FEB' or DEPARTDATE = '2-feb'";
                SqlCommand cmd2feb = new SqlCommand(sql2feb, con);
                Int32 count2feb = (Int32)cmd2feb.ExecuteScalar();
                feb2 = count2feb;
                con.Close();

                con.Open();
                String sql7feb = "SELECT COUNT(ID) AS '7 FEB' FROM DRIVER WHERE DEPARTDATE = '7 FEB' or DEPARTDATE = '7-feb'";
                SqlCommand cmd7feb = new SqlCommand(sql7feb, con);
                Int32 count7feb = (Int32)cmd7feb.ExecuteScalar();
                feb7 = count7feb;
                con.Close();

                con.Open();
                String sql8feb = "SELECT COUNT(ID) AS '8 FEB' FROM DRIVER WHERE DEPARTDATE = '8 FEB' or DEPARTDATE = '8-feb'";
                SqlCommand cmd8feb = new SqlCommand(sql8feb, con);
                Int32 count8feb = (Int32)cmd8feb.ExecuteScalar();
                feb8 = count8feb;
                con.Close();

                con.Open();
                String sql9feb = "SELECT COUNT(ID) AS '9 FEB' FROM DRIVER WHERE DEPARTDATE = '9 FEB' or DEPARTDATE = '9-feb'";
                SqlCommand cmd9feb = new SqlCommand(sql9feb, con);
                Int32 count9feb = (Int32)cmd9feb.ExecuteScalar();
                feb9 = count9feb;
                con.Close();
                #endregion
            }

            GridviewBind();
        }

        protected void GridviewBind()
        {
            using (SqlConnection con = new SqlConnection("Server=tcp:festive.database.windows.net,1433;Initial Catalog=FestiveDB;Persist Security Info=False;User ID=admin_festive;Password=P@55w0rd2018;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                #region display email list
                con.Open();
                SqlCommand cmd = new SqlCommand("Select ID,EMAIL FROM DRIVER where FESTIVE = 'RAYA2019'", con);
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
                //public int str31jan = count;
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