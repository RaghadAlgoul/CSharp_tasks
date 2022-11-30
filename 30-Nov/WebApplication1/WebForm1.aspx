<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="num1"></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>


            <br />
            <br />


            <asp:Label ID="Label2" runat="server" Text="num2"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 19px"></asp:TextBox>
            <br />
            <br/>


             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;


             <asp:Button ID="sum" runat="server" Text="+" OnClick="sum_Click" Width="34px" />
            &nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Button ID="sub" runat="server" Text="-" OnClick="sub_Click" style="margin-left: 0px" Width="36px" />&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Button ID="mul" runat="server" Text="*" OnClick="mul_Click" Width="33px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Button ID="div" runat="server" Text="/" OnClick="div_Click" Height="30px" Width="41px" />
            <br />
            <br/>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:Label ID="Label3" runat="server" Text="0"></asp:Label>

            <br/>
            <br/>
             <asp:Button ID="Button" runat="server" Text="new label" OnClick="Button_Click" />


            
            

        </div>
    </form>
    
    
</body>
</html>
