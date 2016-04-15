<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MyOAuth.Client.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width:500px; height:230px; background-color:#CCFF99" >
    
        <font style="font-size: 30px; font-weight: bold">Client——登陆</font><br />
    <br /><br />
        略<br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:HyperLink ID="lnkLogin" Font-Size="15px" Font-Bold="True" runat="server">使用社交账号登陆</asp:HyperLink>
        <font color="red"><asp:Literal ID="litLoginResult" runat="server"></asp:Literal></font>
        <br />
    
    </div>
    </form>
</body>
</html>
