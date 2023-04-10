<%@ Page Language="C#" AutoEventWireup="true" CodeFile="hgvgvhvhv_a_dd_hh-art.aspx.cs"
    Inherits="prv_hgvgvhvhv_a_dd_hh_art" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title runat="server">مطالب</title>
    <style type="text/css">
        #form1
        {
            direction: ltr;
        }
        
        .right
        {
            float: right;
            direction: Rtl;
        }
        .txt_r
        {
            direction:rtl;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
        <asp:Label Style="float: right; font-size: 20px;" ID="Label2" runat="server" Text="تایتل مطلب"
            Height="21px" Width="121px"></asp:Label>
        <asp:TextBox Style="float: right; font-size: 20px;" ID="title_txt" runat="server"
            Width="990px" CssClass="txt_r"></asp:TextBox>
    </div>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <asp:Label ID="Label6" runat="server" Height="20px" Style="float: right; font-size: 20px;"
        Text="کلمات کلیدی ( مربوط به تگ متا)"></asp:Label>
    <asp:TextBox ID="meta_key" runat="server" Height="111px" Style="float: right;" 
        Width="824px" CssClass="txt_r"></asp:TextBox><br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="Label7" runat="server" Height="20px" Style="float: right; font-size: 20px;"
        Text="جملات کلیدی ( مربوط به تگ متا )"></asp:Label>
    <asp:TextBox ID="meta_desc" runat="server"
            Height="87px" Style="float: right;" Width="824px" CssClass="txt_r"></asp:TextBox>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="Label8" runat="server" Height="65px" Style="float: right; font-size: 20px;"
        Text="توضیحات مختصر جهت نمایش در زیر مطلب" Width="146px"></asp:Label>
    <asp:TextBox Style="float: right;" ID="paper_cmt" runat="server" Height="73px" 
        Width="656px" CssClass="txt_r"></asp:TextBox><br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="link_label" runat="server" Height="20px" Style="float: right; font-size: 20px;"
        Text="لینک مطلب ( متن تنها )"></asp:Label>
    <asp:TextBox ID="paper_link" runat="server" Style="float: right;" Width="702px" 
        CssClass="txt_r"></asp:TextBox>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Button ID="add_pic" runat="server" Height="32px" OnClick="add_pic_Click" Text="افزوردن"
        Width="105px" />
    <asp:FileUpload ID="edi_add" runat="server" Height="27px" />
    <br />
    <CKEditor:CKEditorControl ID="CKEditorControl1" runat="server" Height="306px">
    </CKEditor:CKEditorControl>
    <br />
    <br />
    <br />
    <br />
    <asp:Label Style="float: right;" ID="Label10" runat="server" Text="عکس شاخص مطلب"></asp:Label>
    <asp:FileUpload Style="float: right;" ID="img_Upload" runat="server" />
    <br />
    <br />
    <asp:Button Style="float: right;" ID="btn_publish" runat="server" Text="تأیید و انتشار مطلب"
        Font-Size="X-Large" Height="111px" OnClick="btn_publish_Click" Width="257px" />
    <br />
    <asp:Button ID="btn_cp" runat="server" Height="80px" OnClick="btn_cp_Click" Text="بازگشت به کنترل پنل"
        Width="156px" />
    <br />
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="r"
            DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display."
            EnableModelValidation="True" CellPadding="4" ForeColor="#333333" GridLines="None"
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
                <asp:HyperLinkField DataNavigateUrlFields="r" DataNavigateUrlFormatString="get_to_post.aspx?rp={0}&amp;mode=edi"
                    HeaderText="لینک ویرایش" Text="ویرایش">
                    <ControlStyle CssClass="img_edi"></ControlStyle>
                </asp:HyperLinkField>
                <asp:HyperLinkField DataNavigateUrlFields="r,paper_link,img" DataNavigateUrlFormatString="del_posts.aspx?r={0}&amp;link={1}&amp;img={2}&amp;posttype=art"
                    HeaderText="حذف مطلب" Text="حذف" />
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
    </p>
    </form>
</body>
</html>
