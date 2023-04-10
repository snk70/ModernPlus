<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="prv_bdsgsdfgsdfg_dsdfgsdfgsdfgsdfgsdfg_mng_pnl_wbs_adsjkfasf_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>پنل مدیریتی سایت</title>
    <style>
            .right
        {
            float:right;
            direction:ltr;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
    
    </div>
    <asp:TextBox ID="txt_username" runat="server" Width="420px" CssClass="right" 
        placeholder="Username"></asp:TextBox>
    <br />
    <p>
    <asp:TextBox ID="txt_pass" runat="server" Width="420px" CssClass="right" 
            placeholder="Password" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="Button1" runat="server" CssClass="right" Height="70px" 
            onclick="Button1_Click" Text="OK" Width="139px" />
    </p>
    <p style="direction: ltr">
        &nbsp;</p>
    <p style="direction: ltr">
        &nbsp;</p>
    <p style="direction: ltr">
        <asp:Button ID="btn_refresh_menu" runat="server" CssClass="right" Height="48px" 
            Text="بروزرسانی منو" Visible="False" Width="193px" 
            onclick="btn_refresh_menu_Click" />
    </p>
    <p style="direction: ltr">
        &nbsp;</p>
    <p style="direction: ltr">
        <asp:Button ID="btn_refresh" runat="server" CssClass="right" Height="48px" 
            Text="بروز رسانی صفحه اصلی سایت" Visible="False" Width="193px" 
            onclick="btn_refresh_Click" />
    </p>
    <p style="direction: ltr">
        &nbsp;</p>
    <p style="direction: ltr">
        <asp:Button ID="btn_refresh_sitemap" runat="server" CssClass="right" 
            Height="48px" Text="بروز رسانی نقشه سایت" Visible="False" Width="193px" 
            onclick="btn_refresh_sitemap_Click" />
    </p>
    <p style="direction: ltr">
        &nbsp;</p>
    <p style="direction: ltr">
        <asp:Button ID="btn_insert_art" runat="server" CssClass="right" Height="48px" 
            Text="درج مطلب" Visible="False" Width="193px" 
            onclick="btn_insert_art_Click" />
    </p>
    <p style="direction: ltr">
        &nbsp;</p>
    <p style="direction: ltr">
        <asp:Button ID="btn_insert_app" runat="server" CssClass="right" Height="48px" 
            Text="درج محصول" Visible="False" Width="193px" 
            onclick="btn_insert_app_Click" />
    </p>
    <p style="direction: ltr">
        &nbsp;</p>
    <p style="direction: ltr">
        <asp:Button ID="btn_edit_menu" runat="server" CssClass="right" Height="48px" 
            Text="ویرایش منو" Visible="False" Width="193px" 
            onclick="btn_edit_menu_Click" />
    </p>
    <p style="direction: ltr">
        &nbsp;</p>
    <p style="direction: ltr">
        <asp:Button ID="btn_comments_contacts" runat="server" CssClass="right" Height="48px" 
            Text="مدیریت نظرات و پیام ها" Visible="False" Width="193px" 
            onclick="btn_comments_contacts_Click1" />
    </p>
    <asp:Button ID="btn_Exit" runat="server" BackColor="Red" Height="63px" 
        onclick="btn_Exit_Click" Text="خروج" Width="80px" />
    </form>
    </body>
</html>
