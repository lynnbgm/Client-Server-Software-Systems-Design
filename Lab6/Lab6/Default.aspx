<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Online Voting System</title>
</head>
<body class="background">
    <style type="text/css">
        .background{
            background-color: #202e38;
        }
    </style>
    <style type="text/css">
        .title{
            font-family: "Poppins", sans-serif;
            font-size: 30px;
            color: #FFFFFF;
            text-align:center;
        }
    </style>
    <style type="text/css">
        .image{
            text-align:center;
        }
    </style>
    <style type="text/css">
        .radiobuttons{
            display:inline-block;
            font-family: "Poppins", sans-serif;
            font-size: 15px;
            color:whitesmoke;
            margin: 15px;
        }
    </style>
    <style>
        .button {
            display:inline-block;
            border-radius:8px;
            height:40px; 
            Width: 100px;
            background-color: #1BB495;
            color: white;
            border: 1px;
            border-color: #1BB495;
            font-weight:bold;
        }
        .button:hover{
            background-color:#139077;
            color:white;
        }
    </style>
    <style>
        .error{
            display:inline-block;
            margin: 10px;
            font-family: "Poppins", sans-serif;
            color:#FBD066;
            font-weight:bold;
        }
    </style>
    <style>
        .container{
            text-align:center;
        }
    </style>
    <form id="form1" runat="server">
            <!-- Green:#1BB495 Yellow:#FBD066 -->
            <asp:SqlDataSource ID="Candidatedb" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Votes]"></asp:SqlDataSource>
            <div class="image">
                <img src="\Images\vote.png" alt="Vote Logo" />
            </div>
            <div class="title">
                <b>
                    <asp:Label ID="software" runat="server" Text="Veritas" Font-Size="30px" ForeColor="#FBD066"></asp:Label>
                    <asp:Label ID="header_poll" runat="server" Text="Webpage" Font-Size="30px"></asp:Label>
                    <asp:Label ID="app" runat="server" Text="Application" Font-Size="30px" ForeColor="#FBD066"></asp:Label>
                </b>
                    <br />
                    <asp:Label ID="subtitle" runat="server" Text="Online Voting System" Font-Size="20px"></asp:Label>
            </div>
        <div class="container">
            <br />
            <br />
            <div class="radiobuttons">
                <asp:RadioButtonList ID="Candidatelist" runat="server" DataSourceID="Candidatedb" DataTextField="name" DataValueField="name">
                </asp:RadioButtonList>
            </div>
            <br />
            <b><asp:Button ID="go" runat="server" Text="VOTE" OnClick="go_Click" CssClass="button" /></b>
            <br />
            <div class="error">
                <asp:Label ID="error" runat="server" Text="Error: No candidates selected." Visible="false"></asp:Label>
            </div>
         </div> 
    </form>
</body>
</html>