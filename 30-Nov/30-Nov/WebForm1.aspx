<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_30_Nov.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="StyleSheet2.css"  />
    <title></title>
</head>
<body >
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="titel" runat="server" Text="Calculator" Font-Bold="True" Font-Size="Larger"></asp:Label>
            <br />
            <asp:Label ID="textstore" runat="server" Text=" 0"></asp:Label>
            <br />
            <asp:Label ID="result" runat="server" Text="0"></asp:Label>
            <br />
            <div style="margin-left:10%">
            <asp:Button ID="num1" CssClass="butstyle" runat="server" Text="1" Width="110px" ForeColor="#666699" Height="60px" OnClick="num1_Click"/>
            <asp:Button ID="num2" CssClass="butstyle" runat="server" Text="2" Width="110px" Height="60px" OnClick="num2_Click" />
            <asp:Button ID="num3" CssClass="butstyle" runat="server" Text="3" Width="110px" Height="60px" OnClick="num3_Click" />
            <asp:Button ID="num4" CssClass="butstyle" runat="server" Text="4" Width="110px" Height="60px" OnClick="num4_Click" />
            <asp:Button ID="num5" CssClass="butstyle" runat="server" Text="5" Width="110px" Height="60px" OnClick="num5_Click"/>
            <asp:Button ID="num6" CssClass="butstyle" runat="server" Text="6" Width="110px" Height="60px" OnClick="num6_Click"/>
            <asp:Button ID="num7" CssClass="butstyle" runat="server" Text="7" Width="110px" Height="60px" OnClick="num7_Click"/>
            <asp:Button ID="num8" CssClass="butstyle" runat="server" Text="8" Width="110px" Height="60px" OnClick="num8_Click"/>
            <asp:Button ID="num9" CssClass="butstyle" runat="server" Text="9" Width="110px" Height="60px" OnClick="num9_Click" />
            <br /><br /><br />

            </div>
            
            <div id="operation">
            <asp:Button ID="sum"  runat="server" Text="+" Width="200px" Height="70px" OnClick="sum_Click" />
            <asp:Button ID="sub" runat="server" Text="-" Width="200px" Height="70px" OnClick="sub_Click"/><br /><br /><br />
            <asp:Button ID="mul"  runat="server" Text="*" Width="200px" Height="70px" OnClick="mul_Click"/>
            <asp:Button ID="div" runat="server" Text="/" Width="200px" Height="70px" OnClick="div_Click"/><br />
            </div>
        
        </div>
        <asp:Button ID="equal" runat="server" Height="70px" style="margin-left: 595px; margin-top: 31px" Text="Button" Width="200px" OnClick="equal_Click" />
    </form>
</body>
</html>
