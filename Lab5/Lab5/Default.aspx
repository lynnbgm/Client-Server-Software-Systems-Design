<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Currency Exchange</title>
</head>
<body style="background-color:#001f3f">
    <style type="text/css">
        .title{
            margin-top: 50px;
            text-align: center;
            font-family:'Trebuchet MS';
            font-size:xx-large;
            color: white;
        }
    </style>
    <style type="text/css">
        .subtitle{
            margin-bottom: 60px;
            text-align: center;
            font-family:'Trebuchet MS';
            font-size:medium;
            color: white;
        }
    </style>
    <style type="text/css">
        .stretchtxt{
            font-family:'Trebuchet MS';
            font-size:large;
            color: white;
            margin-bottom: 10px;
        }
    </style>
    <style type="text/css">
        .listbox {
            font-family:'Trebuchet MS';
        }
    </style>
    <style type="text/css">
        .section{
            float: left;
            margin: 0 auto;
            margin-left: 20px;
            margin-right: 50px;
        }
    </style>
    <style type="text/css">
        .button{
            margin-top: 30px;
            border-radius:8px;
            height:40px; 
            Width: 100px;
            color: white;
            background-color: coral;
            border: 2px solid coral;
        }
    </style>
    <style type="text/css">
        .error{
            font-family:'Trebuchet MS';
            color:coral;
            font-style:bold;
        }
    </style>
    <style type="text/css">
        .parent{
            margin: 0 auto;
            padding: 0;
            height: 260px;
            width: 900px;
        }
    </style>
    <form id="form1" runat="server">
        <!-- This is the Title & Subtitle -->
        <div class="title">
            <b><asp:Label ID="title_curr" Text="CURRENCY " runat="server" ForeColor="PowderBlue"></asp:Label></b>
            <b><asp:Label ID="Label1" Text="EXCHANGE" runat="server"></asp:Label></b>
        </div>
        <div class="subtitle">
            <asp:Label ID="subtitle" Text="Super Limited Edition" runat="server"></asp:Label>
        </div>
        <asp:SqlDataSource ID="ExchangeRates" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Rates]"></asp:SqlDataSource>
        <div class="parent">
            <!-- This is the List Box -->
            <div class="section">
                <div class="stretchtxt">
                    <asp:Label ID="select" runat="server" Text="S E L E C T"></asp:Label> <br />
                    <asp:Label ID="foreigncurr" runat="server" Text="F O R E I G N"></asp:Label> <br />
                    <asp:Label ID="curr" runat="server" Text="C U R R E N C Y"></asp:Label><br />
                </div>
                <div class="listbox">
                    <asp:ListBox ID="ExchangeDisplay" runat="server" DataSourceID="ExchangeRates" DataTextField="Currency" DataValueField="Exchange" Height="110px" Width="120px"></asp:ListBox>
                </div>
            </div>
            <!-- This is the User input space -->
            <div class="section">
                <div class="stretchtxt">
                    <br />
                    <asp:Label ID="enter" runat="server" Text="E N T E R"></asp:Label> <br />
                    <asp:Label ID="val" runat="server" Text="V A L U E"></asp:Label> <br />
                </div>
                <asp:TextBox ID="Userinput" runat="server" Height="40px" Width="215px" Font-Size="x-large" ForeColor="DimGray"></asp:TextBox>
                <div>
                    <asp:Button ID="ToUSD" runat="server" Text="To USD" OnClick="ToUSD_Click" CssClass="button"/> &nbsp;&nbsp;
                    <asp:Button ID="FromUSD" runat="server" Text="From USD" OnClick="FromUSD_Click" CssClass="button"/>
                </div>
            </div>
            <!-- This is the Conversion Output -->
            <div class="section">
                <div class="stretchtxt">
                    <br />
                    <asp:Label ID="conv" runat="server" Text="C O N V E R S I O N"></asp:Label> <br />
                    <asp:Label ID="OutputMsg" runat="server" Text="" ForeColor="PowderBlue"></asp:Label><br />
                </div>
                <asp:TextBox ID="Output" runat="server" Height="40px" Width="215px" Font-Size="x-large" ForeColor="DimGray" ReadOnly="true"></asp:TextBox>
                <div class="error">
                    <br />
                    <asp:Label ID="errorcode" runat="server" Text="Invalid input: " Visible="false"></asp:Label>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
