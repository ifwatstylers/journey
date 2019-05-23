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
          title: 'Redeem Item Based on Date',
          curveType: 'function',
          legend: { position: 'bottom' }
        };

        var chart = new google.visualization.LineChart(document.getElementById('curve_chart'));

        chart.draw(data, options);
      }
    </script>


<script type="text/javascript">
    window.onload = function () {

        //REDEMOTION ITEMS LIST BASED ON PRODUCTS
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
			        { label: "Pineapple Shake",  y: 100 },
			        { label: "Beriani Udang Galah", y: 200  },
			        { label: "Set Nasi Kandar Ayam", y: 400  },
                    { label: "Ayam Kampung Berulam Budu", y: 200 },
                    { label: "Set Sup Ekor", y: 100 },
			        { label: "Set Sup Tulang", y: 200  },
			        { label: "Mee Rebus Wakomo", y: 400  },
                    { label: "Ikan Baung Masak Tempoyak", y: 200 },
                    { label: "Set Nasi Putih Ikan PatinTempoyak",  y: 100  },
			        { label: "Mata Kucing",  y: 500  }
		        ]
	        }
	        ]
        });
        chartItemsList.render();
        //END REDEMPTION ITEM LIST


        var js31jan = <%=jan31%>;
        var js1feb = <%=feb1%>;
        var js2feb = <%=feb2%>;
        var js7feb = <%=feb7%>;
        var js8feb = <%=feb8%>;
        var js9feb = <%=feb9%>;

        var preCNYcount = js31jan + js1feb + js2feb;
        var postCNYcount = js7feb + js8feb + js9feb;

var chart = new CanvasJS.Chart("chartContainer", {
	theme: "light1", // "light2", "dark1", "dark2"
	animationEnabled: false, // change to true		
	title:{
		text: "Most selected date for Raya Journey"
	},
	data: [
	{
		type: "column",
		dataPoints: [
			{ label: "31 Jan",  y: js31jan },
			{ label: "1 Feb", y: js1feb  },
			{ label: "2 Feb", y: js2feb  },
            { label: "7 Feb", y: js7feb },
            { label: "8 Feb",  y: js8feb  },
			{ label: "9 Feb",  y: js9feb  }
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
				{ y: preCNYcount, indexLabel: "PRE-RAYA" },
				{ y: postCNYcount, indexLabel: "POST-RAYA"}
			]
		}
		]
	});
	chart2.render();
}
</script>


</head>
<body>
    <div class="container" runat="server"> 
       <div id="header" class="row">
           <div class="col-md-5"></div>
           <div class="col-md-2"><img src="images/projek_lebuhraya_utara_selatan.png" width="100%" /></div>
           <%--<div class="col-md-7"><h1><b></b></h1></div>--%>
           <div class="col-md-5"></div>
       </div>
    <form id="form1" runat="server">
        <div id="ForBag" class="row" style="text-align:center;">
            <div class="col-md-6" runat="server" >
                <h2>Bag Redeemed (Realtime):</h2>
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
                <h2>Recent Items Redeemed:</h2>
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
         <div class="row">
            <div class="col-md-12">
                <div id="chartItemsContainer" style="height: 370px; width: 100%;"></div>
                <br />
                <script src="https://canvasjs.com/assets/script/canvasjs.min.js"> </script>
            </div>
        </div>
        
        <div class="row">
            <div class="col-md-12">
                <div id="curve_chart" style="width: 100%; height: 700px"></div>
                <br />
            </div>
        </div>
        
        <div id="ForUser" class="row" style="text-align:center;">
            <div class="col-md-6" runat="server" >
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

              </div>
              <div class="col-md-6" runat="server">
                    <h2>Balance points by items:</h2>
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
        <hr />
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
                 <h2 style="text-align:center;">Total Subscribers Count:
            <asp:Label ID="lblTotalSubscribers" runat="server"></asp:Label>
                </h2>
                 <hr />
                 <br />
             </div>
             <div class="col-md-6" runat="server" >
                    <h2>Top 10 most location from:</h2>
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
                    <h2>Top 10 most location to:</h2>
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
                 <h2>Email Subscribe (by date)</h2>
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
            <h2>Subscribers Email List
                <asp:LinkButton ID="lnkbtnExCSV" runat="server" OnClick="lnkbtnExCSV_Click"></asp:LinkButton><%--btn export here--%>
                 </h2>
                    
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
    </form>
        </div>
</body>
</html>
