<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sdfasdfaskdfasdf_side_adfsasdfjkflkgfbwempk_menu.aspx.cs" Inherits="prv_sdfasdfaskdfasdf_side_adfsasdfjkflkgfbwempk_menu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>مدیریت آیتم های منوی کنار صفحات</title>
    <style type="text/css">
        #form1
        {
            direction: ltr;
        }
        
        .right
        {
            float:right;
            direction:Rtl;
        }
     
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txt_text" runat="server" CssClass="right" Height="48px" 
            Width="838px" placeholder="متن ظاهری آیتم"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="متن ظاهری"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txt_link" runat="server" CssClass="right" Height="48px" 
            Width="838px" placeholder="لینک یا پیوند مربوط به این آیتم"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="لینک"></asp:Label>
    
        <br />
        <br />
        <asp:DropDownList ID="select_cat" runat="server" CssClass="right" 
            Height="45px" Width="362px">
            <asp:ListItem Value="tbl_menu_art">مطلب</asp:ListItem>
            <asp:ListItem Value="tbl_menu_app">محصول ( اپلیکیشن اندروید )</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="btn_insert" runat="server" Height="64px" Text="درج" 
            Width="266px" onclick="btn_insert_Click" />
    
        <br />
        <br />
    
    </div>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ModernPlusConnectionString %>" 
        DeleteCommand="DELETE FROM [tbl_menu_app] WHERE [r] = @r" 
        InsertCommand="INSERT INTO [tbl_menu_app] ([text], [link]) VALUES (@text, @link)" 
        ProviderName="<%$ ConnectionStrings:ModernPlusConnectionString.ProviderName %>" 
        SelectCommand="SELECT [r], [text], [link] FROM [tbl_menu_app]" 
        UpdateCommand="UPDATE [tbl_menu_app] SET [text] = @text, [link] = @link WHERE [r] = @r">
        <DeleteParameters>
            <asp:Parameter Name="r" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="text" Type="String" />
            <asp:Parameter Name="link" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="text" Type="String" />
            <asp:Parameter Name="link" Type="String" />
            <asp:Parameter Name="r" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ModernPlusConnectionString %>" 
        DeleteCommand="DELETE FROM [tbl_menu_art] WHERE [r] = @r" 
        InsertCommand="INSERT INTO [tbl_menu_art] ([text], [link]) VALUES (@text, @link)" 
        ProviderName="<%$ ConnectionStrings:ModernPlusConnectionString.ProviderName %>" 
        SelectCommand="SELECT [r], [text], [link] FROM [tbl_menu_art]" 
        UpdateCommand="UPDATE [tbl_menu_art] SET [text] = @text, [link] = @link WHERE [r] = @r">
        <DeleteParameters>
            <asp:Parameter Name="r" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="text" Type="String" />
            <asp:Parameter Name="link" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="text" Type="String" />
            <asp:Parameter Name="link" Type="String" />
            <asp:Parameter Name="r" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <asp:GridView ID="data_art" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="r" DataSourceID="SqlDataSource3" 
        EmptyDataText="There are no data records to display." CssClass="right" 
        Width="482px" AllowPaging="True" AllowSorting="True" 
        EnableModelValidation="True" CellPadding="5" CellSpacing="10">
        <Columns>
            <asp:BoundField DataField="r" HeaderText="ردیف" ReadOnly="True" 
                SortExpression="r" />
            <asp:BoundField DataField="text" HeaderText="متن ظاهری" SortExpression="text" />
            <asp:BoundField DataField="link" HeaderText="لینک مطلب" SortExpression="link" />
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" 
                ButtonType="Button" CancelText="لغو" DeleteText="حذف" EditText="ویرایش" 
                InsertText="درج" UpdateText="بروزرسانی" />
        </Columns>
    </asp:GridView>
    <br /><br /><br /><br /><br />
        <asp:Button ID="btn_back" runat="server" Height="64px" Text="بازگشت به پنل مدیریتی سایت" 
            Width="266px" onclick="btn_back_Click" />
    
        <br />    <br /><br /><br /><br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br /><br />
    <asp:GridView ID="data_app" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="r" DataSourceID="SqlDataSource4" 
        EmptyDataText="There are no data records to display." CssClass="right" 
        Width="479px" AllowPaging="True" AllowSorting="True" CellPadding="5" 
        CellSpacing="10" EnableModelValidation="True">
        <Columns>
            <asp:BoundField DataField="r" HeaderText="ردیف" ReadOnly="True" 
                SortExpression="r" />
            <asp:BoundField DataField="text" HeaderText="متن ظاهری" SortExpression="text" />
            <asp:BoundField DataField="link" HeaderText="لینک" SortExpression="link" />
            <asp:CommandField ButtonType="Button" CancelText="لغو" DeleteText="حذف" 
                EditText="ویرایش" ShowDeleteButton="True" ShowEditButton="True" 
                UpdateText="بروزرسانی" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource4" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ModernPlusConnectionString %>" 
        DeleteCommand="DELETE FROM [tbl_menu_app] WHERE [r] = @r" 
        InsertCommand="INSERT INTO [tbl_menu_app] ([text], [link]) VALUES (@text, @link)" 
        ProviderName="<%$ ConnectionStrings:ModernPlusConnectionString.ProviderName %>" 
        SelectCommand="SELECT [r], [text], [link] FROM [tbl_menu_app]" 
        UpdateCommand="UPDATE [tbl_menu_app] SET [text] = @text, [link] = @link WHERE [r] = @r">
        <DeleteParameters>
            <asp:Parameter Name="r" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="text" Type="String" />
            <asp:Parameter Name="link" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="text" Type="String" />
            <asp:Parameter Name="link" Type="String" />
            <asp:Parameter Name="r" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ModernPlusConnectionString %>" 
        DeleteCommand="DELETE FROM [tbl_menu_art] WHERE [r] = @r" 
        InsertCommand="INSERT INTO [tbl_menu_art] ([text], [link]) VALUES (@text, @link)" 
        ProviderName="<%$ ConnectionStrings:ModernPlusConnectionString.ProviderName %>" 
        SelectCommand="SELECT [r], [text], [link] FROM [tbl_menu_art]" 
        UpdateCommand="UPDATE [tbl_menu_art] SET [text] = @text, [link] = @link WHERE [r] = @r">
        <DeleteParameters>
            <asp:Parameter Name="r" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="text" Type="String" />
            <asp:Parameter Name="link" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="text" Type="String" />
            <asp:Parameter Name="link" Type="String" />
            <asp:Parameter Name="r" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    </form>
</body>
</html>
