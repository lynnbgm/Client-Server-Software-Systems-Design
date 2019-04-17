<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Votes.aspx.cs" Inherits="Votes" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Election Results</title>
</head>
<body class="background">
    <style type="text/css">
        .background{
            background-color: #202e38;
        }
    </style>
    <style>
        .title{
            color:white;
            font-family:"Trebuchet MS";
            font-size: 40px;
            text-align:center;
            font-weight:bold;
        }
    </style>
    <style type="text/css">
        .image{
        text-align:center;
        }
    </style>
    <style>
        .table{
            border-radius:8px;
            font-family:"Trebuchet MS";
            font-weight:bold;
            background-color: #FBD066;
            color:black;
        }
    </style>
    <form id="form1" runat="server">
        <!-- Green:#1BB495 Yellow:#FBD066 -->
         <div class="image">
            <img src="/Images/businessman.png" alt="thumbs up"/>
        </div>
        <div class="title">
            <asp:Label ID="thankyou" runat="server" Text="Thank you for"></asp:Label>
            <asp:Label ID="voting" runat="server" Text="Voting" ForeColor="#1BB495"></asp:Label>
            <asp:Label ID="exclamationpoint" runat="server" Text="!"></asp:Label>
        </div>
       
        <asp:SqlDataSource ID="CandidateData" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Votes]"></asp:SqlDataSource>
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="CandidateData">
        </asp:Repeater>
        <br />
        <br />
        <asp:Table ID="result_display" runat="server" HorizontalAlign="Center" CssClass="table">
        </asp:Table>
    </form>
</body>
</html>
