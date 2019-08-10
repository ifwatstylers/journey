<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="journey.Admin.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Journey PLUS Analytics Report</title>
    <link rel="stylesheet" type="text/css" href="css/util.css">
	<link rel="stylesheet" type="text/css" href="css/main.css">
    <!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/bootstrap/css/bootstrap.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="fonts/font-awesome-4.7.0/css/font-awesome.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="fonts/iconic/css/material-design-iconic-font.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/animate/animate.css">
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="vendor/css-hamburgers/hamburgers.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/animsition/css/animsition.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/select2/select2.min.css">
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="vendor/daterangepicker/daterangepicker.css">
<!--===============================================================================================-->


<script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
<script type="text/javascript">
      google.charts.load('current', {'packages':['corechart']});
      google.charts.setOnLoadCallback(drawChart);

      function drawChart() {
        var data = google.visualization.arrayToDataTable([
          ['Date', 'RB Large Float Single Scoop', 'Glazed Donuts', 'Jambu Madu', 'Mango Shake'],
          ['29 May',  1000, 400, 300, 650],
          ['30 May',  1170, 460, 400, 100],
            ['31 May', 660, 1120, 200, 800],
            ['01 June', 400, 800, 1000, 100],
          ['02 June',  1200, 970, 550, 700],
            ['03 June', 1030, 580, 350, 600],
          ['04 June',  850, 700, 200, 800],
          ['05 June',  680, 606, 300, 100],
            ['06 June', 660, 1000, 800, 900],
            ['07 June', 800, 500, 400, 700],
          ['08 June',  460, 1120, 900, 400],
          ['09 June',  1030, 540, 800, 600]
        ]);

        var options = {
          title: 'Total redeem based on item',
          curveType: 'function',
          legend: { position: 'bottom' }
        };

        var chart = new google.visualization.LineChart(document.getElementById('curve_chart'));

        chart.draw(data, options);
      }
    </script>

<script type="text/javascript">
    window.onload = function () {

        //BAR CHART - REDEMOTION ITEMS LIST BASED ON PRODUCTS
        var jsJuteBag = "<%=jutebag%>";
        var jsSunShade = "<%=sunshade%>";


        var jsProName1 = "<%=csProName1%>";
        var jsProName2 = "<%=csProName2%>";
        var jsProName3 = "<%=csProName3%>";
        var jsProName4 = "<%=csProName4%>";
        var jsProName5 = "<%=csProName5%>";
        var jsProName6 = "<%=csProName6%>";
        var jsProName7 = "<%=csProName7%>";
        var jsProName8 = "<%=csProName8%>";
        var jsProName9 = "<%=csProName9%>";
        var jsProName10 = "<%=csProName10%>";

        var jsProName11 = "<%=csProName11%>";
        var jsProName12 = "<%=csProName12%>";
        var jsProName13 = "<%=csProName13%>";
        var jsProName14 = "<%=csProName14%>";
        var jsProName15 = "<%=csProName15%>";
        var jsProName16 = "<%=csProName16%>";
        var jsProName17 = "<%=csProName17%>";
        var jsProName18 = "<%=csProName18%>";
        var jsProName19 = "<%=csProName19%>";
        var jsProName20 = "<%=csProName20%>";
        
        

        var jsProCount1 = "<%=csProCount1%>";
        var intProCount1 = parseInt(jsProCount1, 10);
        var jsProCount2 = "<%=csProCount2%>";
        var intProCount2 = parseInt(jsProCount2, 10);
        var jsProCount3 = "<%=csProCount3%>";
        var intProCount3 = parseInt(jsProCount3, 10);
        var jsProCount4 = "<%=csProCount4%>";
        var intProCount4 = parseInt(jsProCount4, 10);
        var jsProCount5 = "<%=csProCount5%>";
        var intProCount5 = parseInt(jsProCount5, 10);
        var jsProCount6 = "<%=csProCount6%>";
        var intProCount6 = parseInt(jsProCount6, 10);
        var jsProCount7 = "<%=csProCount7%>";
        var intProCount7 = parseInt(jsProCount7, 10);
        var jsProCount8 = "<%=csProCount8%>";
        var intProCount8 = parseInt(jsProCount8, 10);
        var jsProCount9 = "<%=csProCount9%>";
        var intProCount9 = parseInt(jsProCount9, 10);
        var jsProCount10 = "<%=csProCount10%>";
        var intProCount10 = parseInt(jsProCount10, 10);

        var jsProCount11 = "<%=csProCount11%>";
        var intProCount11 = parseInt(jsProCount11, 10);
        var jsProCount12 = "<%=csProCount12%>";
        var intProCount12 = parseInt(jsProCount12, 10);
        var jsProCount13 = "<%=csProCount13%>";
        var intProCount13 = parseInt(jsProCount13, 10);
        var jsProCount14 = "<%=csProCount14%>";
        var intProCount14 = parseInt(jsProCount14, 10);
        var jsProCount15 = "<%=csProCount15%>";
        var intProCount15 = parseInt(jsProCount15, 10);
        var jsProCount16 = "<%=csProCount16%>";
        var intProCount16 = parseInt(jsProCount16, 10);
        var jsProCount17 = "<%=csProCount17%>";
        var intProCount17 = parseInt(jsProCount17, 10);
        var jsProCount18 = "<%=csProCount18%>";
        var intProCount18 = parseInt(jsProCount18, 10);
        var jsProCount19 = "<%=csProCount19%>";
        var intProCount19 = parseInt(jsProCount19, 10);
        var jsProCount20 = "<%=csProCount20%>";
        var intProCount20 = parseInt(jsProCount20, 10);

        var chartItemsList = new CanvasJS.Chart("chartItemsContainer", {
	        theme: "light2", // "light2", "dark1", "dark2"
	        animationEnabled: false, // change to true		
	        title:{
		        text: "Redemption based on items"
	        },
	        data: [
                {
                    type: "column",
                    dataPoints: [

                        { label: jsProName1, y: intProCount1 },
                        { label: jsProName2, y: intProCount2 },
                        { label: jsProName3, y: intProCount3 },
                        { label: jsProName4, y: intProCount4 },
                        { label: jsProName5, y: intProCount5 },
                        { label: jsProName6, y: intProCount6 },
                        { label: jsProName7, y: intProCount7 },
                        { label: jsProName8, y: intProCount8 },
                        { label: jsProName9, y: intProCount9 },
                        { label: jsProName10, y: intProCount10 }
                        //{ label: jsProName11, y: intProCount11 },
                        //{ label: jsProName12, y: intProCount12 },
                        //{ label: jsProName13, y: intProCount13 },
                        //{ label: jsProName14, y: intProCount14 },
                        //{ label: jsProName15, y: intProCount15 },
                        //{ label: jsProName16, y: intProCount16 }
                        //{ label: jsProName17, y: intProCount17  },
                        //         { label: jsProName18, y: intProCount18 },
                        //         { label: jsProName19, y: intProCount19  },
                        //         { label: jsProName20, y: intProCount20 }
                    ]
                }
	        ]
        });
        chartItemsList.render();

        var chartItemsList2 = new CanvasJS.Chart("chartItemsContainer2", {
	        theme: "light2", // "light2", "dark1", "dark2"
	        animationEnabled: false, // change to true		
	        title:{
		        text: "Redemption based on items (cont.)"
	        },
	        data: [
                {
                    type: "column",
                    dataPoints: [

                        
                        { label: jsProName11, y: intProCount11 },
                        { label: jsProName12, y: intProCount12 },
                        { label: jsProName13, y: intProCount13 },
                        { label: jsProName14, y: intProCount14 },
                        { label: jsProName15, y: intProCount15 },
                        { label: jsProName16, y: intProCount16 }
                        //{ label: jsProName17, y: intProCount17  }
                        //         { label: jsProName18, y: intProCount18 },
                        //         { label: jsProName19, y: intProCount19  },
                        //         { label: jsProName20, y: intProCount20 }
                    ]
                }
	        ]
        });
        chartItemsList2.render();
        //END BAR CHART REDEMPTION ITEM LIST

        //LINE GRAPH START HERE
      //  google.charts.load('current', {'packages':['corechart']});
      //google.charts.setOnLoadCallback(drawChart);

      //function drawChart() {
      //  var data = google.visualization.arrayToDataTable([
      //    ['Date', jsProName1, jsProName4, jsProName3, jsProName2, jsProName5],
      //      ['24 May',  intProCount1, intProCount4, intProCount3, intProCount2, intProCount5],
      //      ['29 May', 0, 0, 0, 0],
      //    ['30 May',  0, 0, 0, 0],
      //      ['31 May', 0, 0, 0, 0],
      //      ['01 June', 0, 0, 0, 0],
      //    ['02 June',  0, 0, 0, 0],
      //      ['03 June', 0, 0, 0, 0],
      //    ['04 June',  0, 0, 0, 0],
      //    ['05 June',  0, 0, 0, 0],
      //      ['06 June', 0, 0, 0, 0],
      //      ['07 June', 0, 0, 0, 0],
      //    ['08 June',  0, 0, 0, 0],
      //    ['09 June',  0, 0, 0, 0]
      //  ]);

      //  var options = {
      //    title: 'Redeem Item Based on Date',
      //    curveType: 'function',
      //    legend: { position: 'bottom' }
      //  };

      //  var chart = new google.visualization.LineChart(document.getElementById('curve_chart'));

      //  chart.draw(data, options);
      //}
        //END LINE GRAPH HERE


        var jsDay1 = <%=csDay1%>;
        var jsDay2 = <%=csDay2%>;
        var jsDay3 = <%=csDay3%>;
        var jsDay4 = <%=csDay4%>;
        var jsDay5 = <%=csDay5%>;
        var jsDay6 = <%=csDay6%>;

        var jsDay7 = <%=csDay7%>;
        var jsDay8 = <%=csDay8%>;
        var jsDay9 = <%=csDay9%>;
        var jsDay10 = <%=csDay10%>;
        var jsDay11 = <%=csDay11%>;
        var jsDay12 = <%=csDay12%>;

        var preCount = jsDay1 + jsDay2 + jsDay3 + jsDay4 + jsDay5 + jsDay6;
        var postCount = jsDay7 + jsDay8 + jsDay9 + jsDay10 + jsDay11 + jsDay12;

var chart = new CanvasJS.Chart("chartContainer", {
	theme: "light2", // "light2", "dark1", "dark2"
	animationEnabled: true, // change to true		
	title:{
		text: "Most selected date for Raya Journey"
	},
	data: [
	{
		type: "column",
		dataPoints: [
			{ label: "29 May",  y: jsDay1 },
			{ label: "30 May", y: jsDay2  },
			{ label: "31 May", y: jsDay3  },
            { label: "1 June", y: jsDay4 },
            { label: "2 June",  y: jsDay5  },
            { label: "3 June", y: jsDay6 },
            { label: "5 June",  y: jsDay7 },
			{ label: "6 June", y: jsDay8  },
			{ label: "7 June", y: jsDay9  },
            { label: "8 June", y: jsDay10 },
            { label: "9 June",  y: jsDay11  },
			{ label: "10 June",  y: jsDay12  }
		]
	}
	]
});
chart.render();


        var chart2 = new CanvasJS.Chart("chartContainer2",
	{
		title:{
			text: "Pre vs. Post"
		},
		legend: {
			maxWidth: 350,
			itemWidth: 120
		},
		data: [
		{
			type: "pie",
			showInLegend: true,
			legendText: "{indexLabel}",
			dataPoints: [
				{ y: preCount, indexLabel: "PRE-RAYA" },
				{ y: postCount, indexLabel: "POST-RAYA"}
			]
		}
		]
	});
	chart2.render();
}
</script>

<style>
ul {
  list-style-type: none;
  margin: 0;
  padding: 0;
  overflow: hidden;
  background-color: #333;
}

li {
  float: left;
}

li a {
  display: block;
  color: white;
  text-align: center;
  padding: 14px 16px;
  text-decoration: none;
}

li a:hover {
  background-color: #111;
}
</style>

<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
<script>

    $(document).ready(function () {
        $("#ForBag").show();
        $("#itemredeem").hide();
        $("#tta").hide();

        $("#ForBagBtn").click(function () {
            $("#ForBag").show();
            $("#itemredeem").hide();
            $("#tta").hide();
        });
        $("#itemredeemBtn").click(function () {
            $("#ForBag").hide();
            $("#itemredeem").show();
            $("#tta").hide();
        });
        $("#ttaBtn").click(function () {
            $("#ForBag").hide();
            $("#itemredeem").hide();
            $("#tta").show();
        });

    });
</script>

</head>
<body class="stretched">
    <ul>
  <li><a class="active" href="#ForBagBtn" id="ForBagBtn">OLE OLE RAYA PLUS Activation Booth</a></li>
  <li><a href="#itemredeemBtn" id="itemredeemBtn">PLUSMiles Points Redemption</a></li>
  <li><a href="#ttaBtn" id="ttaBtn">Travel Time Advisory Registration</a></li>
  
</ul>
    <div id="header" class="row">
           <div class="col-md-12"><img src="images/oleolerayabanner.jpg" width="100%"/></div>
       </div>
    <div class="container" runat="server"> 
        <div class="row">
            <div class="col-md-12"><br /><br /></div>
        </div>
       
    <form id="form1" runat="server">
        <div id="ForBag" class="row" style="text-align:center;">
            <div class="col-md-6" runat="server" >
                <h3>Activation Booth (Jute Bag) - 
                    <asp:Label ID="lblJuteBagCount" runat="server"></asp:Label>
                </h3>
                <asp:GridView ID="gvBagRedeem" runat="server" BackColor="White" 
              BorderColor="#3366CC" BorderStyle="None" 
              BorderWidth="1px" CellPadding="4"
              style="text-align: center; margin-left: 10px; margin-bottom: 0px;" Width="100%" PageSize="50">
              <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
              <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
              <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
              <RowStyle BackColor="White" ForeColor="#003399" />
              <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
              <SortedAscendingCellStyle BackColor="#EDF6F6" />
              <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
              <SortedDescendingCellStyle BackColor="#D6DFDF" />
              <SortedDescendingHeaderStyle BackColor="#002876" />
       </asp:GridView>
            </div>
            <div class="col-md-6" runat="server" >
                <h3>Activation Booth (Sunshade) -
                    <asp:Label ID="lblSunShadeCount" runat="server"></asp:Label>
                </h3>
                <asp:GridView ID="gvRecentItemRedeem" runat="server" BackColor="White" 
              BorderColor="#3366CC" BorderStyle="None" 
              BorderWidth="1px" CellPadding="4"
              style="text-align: center; margin-left: 10px; margin-bottom: 0px;" Width="100%" PageSize="50">
              <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
              <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
              <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
              <RowStyle BackColor="White" ForeColor="#003399" />
              <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
              <SortedAscendingCellStyle BackColor="#EDF6F6" />
              <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
              <SortedDescendingCellStyle BackColor="#D6DFDF" />
              <SortedDescendingHeaderStyle BackColor="#002876" />
       </asp:GridView>
            </div>
            <br /><br /><br />
            </div>
        
        <div id="itemredeem">
                     <div class="row">
            <div class="col-md-12">
                <div id="chartItemsContainer" style="height: 570px; width: 100%;"></div>
                <br />
                <script src="https://canvasjs.com/assets/script/canvasjs.min.js"> </script>
            </div>
                         <div class="col-md-12">
                <div id="chartItemsContainer2" style="height: 570px; width: 100%;"></div>
                <br />
                <script src="https://canvasjs.com/assets/script/canvasjs.min.js"> </script>
            </div>
        </div>
        
      <%--  <div class="row">
            <div class="col-md-12">
                <div id="curve_chart" style="width: 100%; height: 700px"></div>
                <br />
            </div>
        </div>--%>        
            <%--<div class="col-md-6" runat="server" >
                    <h2>Highest redemption by user:</h2>
                    <asp:GridView ID="gvHighestUser" runat="server" BackColor="White" 
              BorderColor="#3366CC" BorderStyle="None" 
              BorderWidth="1px" CellPadding="4"
              style="text-align: center; margin-left: 10px; margin-bottom: 0px;" Width="100%" PageSize="50">
              <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
              <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
              <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
              <RowStyle BackColor="White" ForeColor="#003399" />
              <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
              <SortedAscendingCellStyle BackColor="#EDF6F6" />
              <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
              <SortedDescendingCellStyle BackColor="#D6DFDF" />
              <SortedDescendingHeaderStyle BackColor="#002876" />
       </asp:GridView>

              </div>--%>


              <div class="col-md-12" runat="server">
                    <h3>PLUSMiles Points Redemption</h3>
                    <asp:GridView ID="gvBalPoint" runat="server" BackColor="White" 
              BorderColor="#3366CC" BorderStyle="None" 
              BorderWidth="1px" CellPadding="4"
              style="text-align: center; margin-left: 10px; margin-bottom: 0px;" Width="100%" PageSize="50">
              <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
              <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
              <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
              <RowStyle BackColor="White" ForeColor="#003399" />
              <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
              <SortedAscendingCellStyle BackColor="#EDF6F6" />
              <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
              <SortedDescendingCellStyle BackColor="#D6DFDF" />
              <SortedDescendingHeaderStyle BackColor="#002876" />
       </asp:GridView>
             </div>
            <br /><br />
        
        </div>

        <div id="tta">
            <div class="row">
            <div class="col-md-12">
                <div id="chartContainer" style="height: 370px; width: 100%;"></div>
                <script src="https://canvasjs.com/assets/script/canvasjs.min.js"> </script>
            </div>
        </div>
        <hr />
        <div class="row">
            <div class="col-md-12">
                <div id="chartContainer2" style="height: 300px; width: 100%;"></div>
                <script type="text/javascript" src="https://canvasjs.com/assets/script/canvasjs.min.js"></script>
            </div>
        </div>
        <br />
         <div class="row" runat="server" style="text-align:center;">
             <div class="col-md-12">
                 <h3 style="text-align:center;">Total Subscribers Count:
            <asp:Label ID="lblTotalSubscribers" runat="server"></asp:Label>
                </h3>
                 <hr />
                 <br />
             </div>
             <div class="col-md-6" runat="server" >
                    <h3>Top 10 most location from:</h3>
                    <asp:GridView ID="gvMostFrom" runat="server" BackColor="White" 
              BorderColor="#3366CC" BorderStyle="None" 
              BorderWidth="1px" CellPadding="4"
              style="text-align: center; margin-left: 10px; margin-bottom: 0px;" Width="100%" PageSize="50">
              <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
              <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
              <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
              <RowStyle BackColor="White" ForeColor="#003399" />
              <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
              <SortedAscendingCellStyle BackColor="#EDF6F6" />
              <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
              <SortedDescendingCellStyle BackColor="#D6DFDF" />
              <SortedDescendingHeaderStyle BackColor="#002876" />
       </asp:GridView>
              </div>
              <div class="col-md-6" runat="server">
                    <h3>Top 10 most location to:</h3>
                    <asp:GridView ID="gvMostTo" runat="server" BackColor="White" 
              BorderColor="#3366CC" BorderStyle="None" 
              BorderWidth="1px" CellPadding="4"
              style="text-align: center; margin-left: 10px; margin-bottom: 0px;" Width="100%" PageSize="50">
              <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
              <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
              <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
              <RowStyle BackColor="White" ForeColor="#003399" />
              <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
              <SortedAscendingCellStyle BackColor="#EDF6F6" />
              <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
              <SortedDescendingCellStyle BackColor="#D6DFDF" />
              <SortedDescendingHeaderStyle BackColor="#002876" />
       </asp:GridView>
             </div>
         </div>
        <hr />
         <div class="row" runat="server" style="text-align:center;">
             <div class="col-md-6" runat="server">
                 <h3>Email Subscribe (by date)</h3>
                 <asp:GridView ID="gvMostUserSubscribe" runat="server" BackColor="White" 
              BorderColor="#3366CC" BorderStyle="None" 
              BorderWidth="1px" CellPadding="4"
              style="text-align: center; margin-left: 10px; margin-bottom: 0px;" Width="100%" PageSize="50">
              <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
              <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
              <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
              <RowStyle BackColor="White" ForeColor="#003399" />
              <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
              <SortedAscendingCellStyle BackColor="#EDF6F6" />
              <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
              <SortedDescendingCellStyle BackColor="#D6DFDF" />
              <SortedDescendingHeaderStyle BackColor="#002876" />
       </asp:GridView>
             </div>
             <div class="col-md-6" runat="server">
            <h3>Subscribers Email List
                <asp:LinkButton ID="lnkbtnExCSV" runat="server" OnClick="lnkbtnExCSV_Click"></asp:LinkButton><%--btn export here--%>
                 </h3>
                    
        <asp:GridView ID="GridView1" runat="server" BackColor="White" 
              BorderColor="#3366CC" BorderStyle="None" 
              BorderWidth="1px" CellPadding="4"
              style="text-align: center; margin-left: 10px; margin-bottom: 0px;" Width="100%" PageSize="50">
              <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
              <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
              <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
              <RowStyle BackColor="White" ForeColor="#003399" />
              <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
              <SortedAscendingCellStyle BackColor="#EDF6F6" />
              <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
              <SortedDescendingCellStyle BackColor="#D6DFDF" />
              <SortedDescendingHeaderStyle BackColor="#002876" />
       </asp:GridView>
                    </div>
         </div>
        </div>
        

    </form>
        </div>
<ul>
  <li><a class="active" href="#">Copyrights &copy; 2019 All Rights Reserved by PLUS MALAYSIA.</a></li>
</ul>
</body>
</html>
