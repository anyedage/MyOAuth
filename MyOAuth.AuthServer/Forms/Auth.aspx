<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Auth.aspx.cs" Inherits="MyOAuth.AuthServer.Auth" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width:500px; height:230px; background-color:#FFCCFF" >
        <font style="font-size: 30px; font-weight: bold">AuthServer——登陆</font><br />
    <br /><br />
    用户：<asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
    <br />
    <br />
    密码：<asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
        <br />
    <br />
    <asp:Literal ID="litContent" runat="server"></asp:Literal>
        <br />
    <br />
    <asp:Button ID="btnAuth" runat="server" onclick="btnAuth_Click" Text="同意授权" 
            Font-Size="15px" Font-Bold="True" />
        <font color="red"><asp:Literal ID="litAuthResult" runat="server"></asp:Literal></font>
    <br />
    </div>
    </form>
</body>
</html>
