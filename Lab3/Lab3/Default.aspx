<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <style type="text/css">
        .backdrop{
            background-color: #C0C0C0;
            margin: 0 auto;
            width: 630px;
            height: 380px;
            border-width:thin;
            border-style: solid;
        }
    </style>
    <style type="text/css">
        .buttons{
            float: left;
            padding: 50px;
            border: 0.5px;
            border-left-color: black;
            border-left-style: solid;
            height: 220px;
            
            
        }
    </style>
    <style type="text/css">
        .int_out{
            padding: 100px;
            float: left;
            width: 240px;
            height: 110px;
            
        }
    </style>
    <div class="backdrop">
        <form id="form1" runat="server">
        
            <div class ="int_out">
                <asp:Label ID="input" runat="server" Text="Input: " Font-Size="Medium"></asp:Label>
                &nbsp;<asp:TextBox ID="in_text" runat="server" Height="20px"></asp:TextBox>
                <br /><br />
                <asp:Label ID="output" runat="server" Text="Result: " Font-Size="Medium"></asp:Label>
                <asp:TextBox ID="out_text" runat="server" Height="20px" ReadOnly ="True"></asp:TextBox>
                <br /><br />
                <asp:Label ID="error" runat="server" Text="Invalid or missing value! " Visible ="False" ForeColor ="Red" BackColor ="White"></asp:Label>
            </div>
            <br />
            <br />
            <div class="buttons">
                <asp:Button ID="enter" runat="server" Text="Enter" Height="25px" Width="50px" OnClick="enter_Click" />
                <br /><br />
                <asp:Button ID="add" runat="server" Text="+" Height="25px"  Width="50px" OnClick="add_Click"/>
                <br /><br />
                <asp:Button ID="sub" runat="server" Text="-" Height="25px"  Width="50px" OnClick="sub_Click"/>
                <br /><br />
                <asp:Button ID="mult" runat="server" Text="X" Height="25px"  Width="50px" OnClick="mult_Click"/>
                <br /><br />
                <asp:Button ID="div" runat="server" Text="/" Height="25px"  Width="50px" OnClick="div_Click"/>
            </div>
        </form>
    </div>
</body>
</html>
