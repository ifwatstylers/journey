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


<script type="text/javascript">
    window.onload = function () {
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
		text: "Most selected date for CNY Journey"
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
			text: "PreCNY vs. PostCNY"
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
				{ y: preCNYcount, indexLabel: "PRE-CNY" },
				{ y: postCNYcount, indexLabel: "POST-CNY"}
			]
		}
		]
	});
	chart2.render();
}
</script>


</head>
<body>
    <asp:Label ID="lbl31JanDriver" runat="server" Visible="False"></asp:Label>
    <div class="container" runat="server"> 
    <form id="form1" runat="server">
        <div class="row">
            <div class="col-md-6">
                <div id="chartContainer" style="height: 370px; width: 100%;"></div>
                <script src="https://canvasjs.com/assets/script/canvasjs.min.js"> </script>
            </div>
            <div class="col-md-6">
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
            <h2>Subscribers Email List</h2>
                    
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
