<%@ Page Language="C#" AutoEventWireup="true" CodeFile="del_posts.aspx.cs" Inherits="prv_del_posts" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        آیا از حذف کردن مطمئن هستید ؟<br />
        <asp:Button ID="btn_yes" runat="server" Height="41px" onclick="btn_yes_Click" 
            Text="بله" Width="98px" />
        <asp:Button ID="btn_can" runat="server" Height="41px" onclick="btn_can_Click" 
            Text="خیر" Width="98px" />
    
    </div>
    </form>
</body>
</html>
