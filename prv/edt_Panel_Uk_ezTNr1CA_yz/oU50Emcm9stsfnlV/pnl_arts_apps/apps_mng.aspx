<%@ Page Language="C#" AutoEventWireup="true" CodeFile="apps_mng.aspx.cs" Inherits="prv_edt_Panel_Uk_ezTNr1CA_yz_oU50Emcm9stsfnlV_pnl_arts_apps_app_mng" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>مدیریت محصولات</title>
    <style type="text/css">
        .right
        {
            float: right;
            direction: Rtl;
        }
        #form1
        {
            direction: ltr;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        مدیریت محصولات<br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="r"
            DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display."
            CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="right" AllowPaging="True"
            AllowSorting="True">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="r" HeaderText="ردیف" ReadOnly="True" SortExpression="r" />
                <asp:BoundField DataField="title" HeaderText="تایتل" SortExpression="title" />
                <asp:BoundField DataField="date" HeaderText="تاریخ" SortExpression="date" />
                <asp:BoundField DataField="name" HeaderText="نام" SortExpression="name" />
                <asp:BoundField DataField="type" HeaderText="نوع" SortExpression="type" />
                <asp:BoundField DataField="price" HeaderText="قیمت" SortExpression="price" />
                <asp:BoundField DataField="time" HeaderText="ساعت" SortExpression="time" />
                <asp:BoundField DataField="meta_title" HeaderText="کلمات کلیدی (متا)" SortExpression="meta_title" />
                <asp:BoundField DataField="meta_desc" HeaderText="جملات کلیدی(متا)" SortExpression="meta_desc" />
                <asp:BoundField DataField="paper_cmt" HeaderText="توضیحات" 
                    SortExpression="paper_cmt" />
                <asp:BoundField DataField="paper_link" HeaderText="لینک" SortExpression="paper_link" />
                <asp:BoundField DataField="img" HeaderText="عکس" SortExpression="img" />
                <asp:HyperLinkField DataNavigateUrlFields="r,paper_link" DataNavigateUrlFormatString="get_to_post.aspx?rp={0}&amp;mode=edit&amp;type=app&amp;link={1}"
                    HeaderText="ویرایش" Text="ویرایش">
                    <ControlStyle CssClass="img_edi"></ControlStyle>
                </asp:HyperLinkField>
                <asp:HyperLinkField DataNavigateUrlFields="r,paper_link,img" DataNavigateUrlFormatString="del_posts.aspx?r={0}&amp;link={1}&amp;img={2}&amp;posttype=app"
                    HeaderText="حذف" Text="حذف" />
                <asp:HyperLinkField DataNavigateUrlFields="paper_link" DataNavigateUrlFormatString="opr_files/ref_pages.aspx?type=app&amp;link={0}"
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
            DeleteCommand="DELETE FROM [tbl_app] WHERE [r] = @r" InsertCommand="INSERT INTO [tbl_app] ([title], [name], [type], [price], [text_boy], [date], [time], [like_code], [telegram], [meta_title], [meta_desc], [paper_cmt], [paper_link], [img], [visit_number]) VALUES (@title, @name, @type, @price, @text_boy, @date, @time, @like_code, @telegram, @meta_title, @meta_desc, @paper_cmt, @paper_link, @img, @visit_number)"
            SelectCommand="SELECT * FROM [tbl_app]"
            
            UpdateCommand="UPDATE [tbl_app] SET [title] = @title, [name] = @name, [type] = @type, [price] = @price, [text_boy] = @text_boy, [date] = @date, [time] = @time, [like_code] = @like_code, [telegram] = @telegram, [meta_title] = @meta_title, [meta_desc] = @meta_desc, [paper_cmt] = @paper_cmt, [paper_link] = @paper_link, [img] = @img, [visit_number] = @visit_number WHERE [r] = @r">
            <DeleteParameters>
                <asp:Parameter Name="r" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="title" Type="String" />
                <asp:Parameter Name="name" Type="String" />
                <asp:Parameter Name="type" Type="String" />
                <asp:Parameter Name="price" Type="String" />
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
                <asp:Parameter Name="name" Type="String" />
                <asp:Parameter Name="type" Type="String" />
                <asp:Parameter Name="price" Type="String" />
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
    <p style="direction: ltr">
        &nbsp;</p>
    <p style="direction: ltr">
        &nbsp;</p>
    <p style="direction: ltr">
        &nbsp;</p>
    <p style="direction: ltr">
        &nbsp;</p>
    <p style="direction: ltr">
        &nbsp;</p>
    <p style="direction: ltr">
        &nbsp;</p>
    <asp:Button ID="btn_main_panel" runat="server" Height="80px" OnClick="btn_main_panel_Click"
        Text="پنل مدیریتی" Width="115px" />
    </form>
    <p style="direction: ltr">
        &nbsp;</p>
</body>
</html>
