<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASPNet2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
        <div>
            Username: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />    
            Password: <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
        </div>
         <p>
             &nbsp;</p>
    </form>
</body>
</html>
