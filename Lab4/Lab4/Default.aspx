<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Find Anagrams</title>
</head>
<body>
    <style type="text/css">
        .backdrop{
            background-color:#C0C0C0;
            border: solid;
            border-width: 1px;
            margin: 0 auto;
            padding: 10px;
            width: 710px;
            height: 310px;
        }
    </style>
    <style type="text/css">
        .header{
            text-align:center;
        }
    </style>

    <div class="backdrop">
        <form id="form1" runat="server">
            <div class="header"><h1>Find Anagrams</h1></div>
            <div>
                <br />
                <asp:Label ID ="enter_char" runat="server" Text="Enter a character string: " Font-Size="Medium"></asp:Label>
                &nbsp; <asp:TextBox ID="in_str" runat="server" Height="20px"></asp:TextBox>
                &nbsp; <asp:CheckBox ID="remove_dup" runat="server" Text="Eliminate Duplicates" />
            </div>

            <div>
                <br />
                <asp:ListBox ID="anagram_display" runat="server" Width="150px" Height="90px"></asp:ListBox>
            </div>

            <div>
                <br />
                <asp:Button ID="find_ana" runat="server" Text="Find Anagrams" Height="25px" Width="120px" OnClick="Calc_anagrams"/>
            </div>

            <div>
                <br />
                <asp:Label ID="comment" runat="server"></asp:Label>
                <br />
            </div>
        </form>
    </div>
</body>
</html>
