<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="cc_lab12._Default" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Personality Test</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ImageButton ID="ImageButton1" runat="server"  ImageUrl="images/flower1.jpg" OnClick="ImageButton1_Click" Width="300" Height="300"/>
    <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="images/flower2.jpg" OnClick="ImageButton2_Click" Width="300" Height="300"/>
    <br />
    <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="images/flower3.jpg" OnClick="ImageButton3_Click" Width="300" Height="300"/>

        <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="images/flower4.jpg" OnClick="ImageButton4_Click" Width="300" Height="300"/>
        <br />
        <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
    </form>

    </body>
</html>