<%@ Page Language="C#" AutoEventWireup="true" CodeFile="arts_mng.aspx.cs" Inherits="prv_edt_Panel_Uk_ezTNr1CA_yz_oU50Emcm9stsfnlV_pnl_arts_apps_arts_mng" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>مدیریت مطالب</title>
    <style type="text/css">

        
        .right
        {
            float: right;
            direction: Rtl;
        }
        </style>
</head>
<body style="direction: ltr">
    <form id="form1" runat="server">
    <div>
    
        <br />
        مدیریت مطالب<br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="r"
            DataSourceID="SqlDataSource1" 
            EmptyDataText="There are no data records to display." CellPadding="4" 
            ForeColor="#333333" GridLines="None"
            CssClass="right" AllowPaging="True" AllowSorting="True">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="r" HeaderText="ردیف" ReadOnly="True" SortExpression="r" />
                <asp:BoundField DataField="title" HeaderText="تایتل مطلب" SortExpression="title" />
                <asp:BoundField DataField="date" HeaderText="تاریخ" SortExpression="date" />
                <asp:BoundField DataField="time" HeaderText="ساعت" SortExpression="time" />
                <asp:BoundField DataField="meta_title" HeaderText="کلمات کلیدی (متا)" SortExpression="meta_title" />
                <asp:BoundField DataField="meta_desc" HeaderText="جملات کلیدی(متا)" SortExpression="meta_desc" />
                <asp:BoundField DataField="paper_cmt" HeaderText="توضیحات مطلب" SortExpression="paper_cmt" />
                <asp:BoundField DataField="paper_link" HeaderText="لینک مطلب" SortExpression="paper_link" />
                <asp:BoundField DataField="img" HeaderText="عکس" SortExpression="img" />
                <asp:HyperLinkField DataNavigateUrlFields="r,paper_link" DataNavigateUrlFormatString="get_to_post.aspx?rp={0}&amp;mode=edit&amp;type=art&amp;link={1}"
                    HeaderText="لینک ویرایش" Text="ویرایش">
                    <ControlStyle CssClass="img_edi"></ControlStyle>
                </asp:HyperLinkField>
                <asp:HyperLinkField DataNavigateUrlFields="r,paper_link,img" DataNavigateUrlFormatString="opr_files/del_pages.aspx?link={1}&amp;posttype=art"
                    HeaderText="حذف مطلب" Text="حذف" />
                <asp:HyperLinkField DataNavigateUrlFields="paper_link" 
                    DataNavigateUrlFormatString="opr_files/ref_pages.aspx?type=art&amp;link={0}" 
                    HeaderText="رفرش صفحه" Text="رفرش" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ModernPlusConnectionString %>"
            DeleteCommand="DELETE FROM [tbl_art] WHERE [r] = @r" InsertCommand="INSERT INTO [tbl_art] ([title], [text_boy], [date], [time], [like_code], [telegram], [meta_title], [meta_desc], [paper_cmt], [paper_link], [img], [visit_number]) VALUES (@title, @text_boy, @date, @time, @like_code, @telegram, @meta_title, @meta_desc, @paper_cmt, @paper_link, @img, @visit_number)"
            ProviderName="<%$ ConnectionStrings:ModernPlusConnectionString.ProviderName %>"
            SelectCommand="SELECT [r], [title], [text_boy], [date], [time], [like_code], [telegram], [meta_title], [meta_desc], [paper_cmt], [paper_link], [img], [visit_number] FROM [tbl_art]"
            UpdateCommand="UPDATE [tbl_art] SET [title] = @title, [text_boy] = @text_boy, [date] = @date, [time] = @time, [like_code] = @like_code, [telegram] = @telegram, [meta_title] = @meta_title, [meta_desc] = @meta_desc, [paper_cmt] = @paper_cmt, [paper_link] = @paper_link, [img] = @img, [visit_number] = @visit_number WHERE [r] = @r">
            <DeleteParameters>
                <asp:Parameter Name="r" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="title" Type="String" />
                <asp:Parameter Name="text_boy" Type="String" />
                <asp:Parameter Name="date" Type="String" />
                <asp:Parameter Name="time" Type="String" />
                <asp:Parameter Name="like_code" Type="String" />
                <asp:Parameter Name="telegram" Type="String" />
                <asp:Parameter Name="meta_title" Type="String" />
                <asp:Parameter Name="meta_desc" Type="String" />
                <asp:Parameter Name="paper_cmt" Type="String" />
                <asp:Parameter Name="paper_link" Type="String" />
                <asp:Parameter Name="img" Type="String" />
                <asp:Parameter Name="visit_number" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="title" Type="String" />
                <asp:Parameter Name="text_boy" Type="String" />
                <asp:Parameter Name="date" Type="String" />
                <asp:Parameter Name="time" Type="String" />
                <asp:Parameter Name="like_code" Type="String" />
                <asp:Parameter Name="telegram" Type="String" />
                <asp:Parameter Name="meta_title" Type="String" />
                <asp:Parameter Name="meta_desc" Type="String" />
                <asp:Parameter Name="paper_cmt" Type="String" />
                <asp:Parameter Name="paper_link" Type="String" />
                <asp:Parameter Name="img" Type="String" />
                <asp:Parameter Name="visit_number" Type="Int32" />
                <asp:Parameter Name="r" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <br />
        <br />
    
    </div>
    <p style="direction: ltr">
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="btn_main_panel" runat="server" Height="80px" 
            onclick="btn_main_panel_Click" Text="پنل مدیریتی" Width="115px" />
    </p>
    </form>
    </body>
</html>
