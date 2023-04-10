<%@ Page Language="C#" AutoEventWireup="true" CodeFile="apps_insert.aspx.cs" Inherits="prv_edt_Panel_Uk_ezTNr1CA_yz_oU50Emcm9stsfnlV_pnl_arts_apps_apps_insert" %>


<%@ Register assembly="CKEditor.NET" namespace="CKEditor.NET" tagprefix="CKEditor" %>

<%@ Register assembly="System.Web.Entity, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" namespace="System.Web.UI.WebControls" tagprefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title id="Title1" runat="server">محصولات</title>
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
             .txt_r
        {
            direction:rtl;
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lbl_mode" runat="server" Text="new"></asp:Label>
        <br />
        <asp:Label ID="lbl_up_img" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lbl_row" runat="server"></asp:Label>
    
        <asp:Label style="float:right;font-size:20px;" ID="Label2" runat="server" 
            Text="تایتل محصول" Height="21px" Width="121px"></asp:Label>
    
        <br />
    
        <br />
    
        <asp:TextBox style="float:right;font-size:20px;" ID="title_txt" runat="server" 
            Width="990px" CssClass="txt_r"></asp:TextBox>
     
    </div>
    <p>&ensp;</p>
    <p>&nbsp;</p>
    <p>
    
        <asp:Label style="float:right;font-size:20px;" ID="lbl_name" runat="server" 
            Text="نام محصول" Height="21px" Width="121px"></asp:Label>
    
        <asp:TextBox style="float:right;font-size:20px;" ID="name_txt" runat="server" 
            Width="990px" CssClass="txt_r"></asp:TextBox>
     
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;<asp:Label style="float:right;font-size:20px;" ID="lbl_type" runat="server" 
            Text="مدل سیستم عامل" Height="21px" Width="121px"></asp:Label>
    
        <asp:TextBox style="float:right;font-size:20px;" ID="type_txt" runat="server" 
            Width="990px" CssClass="txt_r"></asp:TextBox>
     
    </p>
    <p>&ensp;</p>
    <p>
    
        <asp:Label style="float:right;font-size:20px;" ID="lbl_prc" runat="server" 
            Text="قیمت" Height="21px" Width="121px"></asp:Label>
    
        <asp:TextBox style="float:right;font-size:20px;" ID="txt_prc" runat="server" 
            Width="990px" CssClass="txt_r"></asp:TextBox>
     
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <asp:Label ID="Label6" runat="server" Height="20px" 
        style="float:right;font-size:20px;" Text="کلمات کلیدی ( مربوط به تگ متا)"></asp:Label>
    <asp:TextBox ID="meta_key" runat="server" Height="111px" style="float:right;" 
        Width="824px" CssClass="txt_r"></asp:TextBox><br />
    <br /><br /><br /><br /><br /><br /><br /><br />
    <asp:Label ID="Label7" runat="server" Height="20px" 
        style="float:right;font-size:20px;" Text="جملات کلیدی ( مربوط به تگ متا )"></asp:Label>
    <asp:TextBox ID="meta_desc" runat="server" Height="87px" style="float:right;" 
        Width="824px" CssClass="txt_r"></asp:TextBox>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="Label8" runat="server" Height="65px" 
        style="float:right;font-size:20px;" 
        Text="توضیحات مختصر جهت نمایش در زیر مطلب" Width="146px"></asp:Label>

        <asp:TextBox style="float:right;" ID="paper_cmt" runat="server" Height="73px" 
          Width="656px" CssClass="txt_r"></asp:TextBox><br />
    <br />
    <br />
    <br />
    <br />
    <br />
    
    <asp:Label ID="link_label" runat="server" Height="20px" 
        style="float:right;font-size:20px;" Text="لینک محصول ( متن خالی )"></asp:Label>
    <asp:TextBox ID="paper_link" runat="server" style="float:right;" Width="702px" 
        CssClass="txt_r"></asp:TextBox>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Button ID="add_pic" runat="server" Height="32px" onclick="add_pic_Click" 
        Text="افزوردن" Width="105px" />
    <asp:FileUpload ID="edi_add" runat="server" Height="27px" />
    <br />
    <CKEditor:CKEditorControl ID="CKEditorControl1" runat="server" Height="306px">
    </CKEditor:CKEditorControl>
    <br />
    <br />
    <br />
    <br />
    <asp:Label style="float:right;" ID="Label10" runat="server" Text="عکس شاخص مطلب"></asp:Label>
    <asp:FileUpload style="float:right;" ID="img_Upload" runat="server" />
    <br />
    <br />
    <asp:Button style="float:right;" ID="btn_publish" runat="server" 
        Text="تأیید و انتشار محصول" Font-Size="X-Large" Height="111px" 
        onclick="btn_publish_Click" Width="257px" />
    <br />
    <asp:Button ID="btn_cp" runat="server" Height="80px" onclick="btn_cp_Click" 
        Text="بازگشت به کنترل پنل" Width="156px" />
    <br />
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" 
            CellPadding="4" CssClass="right" DataKeyNames="r" DataSourceID="SqlDataSource1" 
            EmptyDataText="There are no data records to display." 
            EnableModelValidation="True" AllowPaging="True" AllowSorting="True">
            <Columns>
                <asp:BoundField DataField="r" HeaderText="ردیف" ReadOnly="True" 
                    SortExpression="r" />
                <asp:BoundField DataField="title" HeaderText="تایتل" SortExpression="title" />
                <asp:BoundField DataField="name" HeaderText="نام محصول" SortExpression="name" />
                <asp:BoundField DataField="type" HeaderText="نوع" SortExpression="type" />
                <asp:BoundField DataField="price" HeaderText="قیمت" SortExpression="price" />
                <asp:BoundField DataField="date" HeaderText="تاریخ" SortExpression="date" />
                <asp:BoundField DataField="time" HeaderText="زمان" SortExpression="time" />
                <asp:BoundField DataField="meta_title" HeaderText="کلمات کلیدی متا" 
                    SortExpression="meta_title" />
                <asp:BoundField DataField="meta_desc" HeaderText="جملات کلیدی متا" 
                    SortExpression="meta_desc" />
                <asp:BoundField DataField="paper_cmt" HeaderText="توضیحات محصول" 
                    SortExpression="paper_cmt" />
                <asp:BoundField DataField="paper_link" HeaderText="لینک" 
                    SortExpression="paper_link" />
                <asp:BoundField DataField="img" HeaderText="عکس" SortExpression="img"/>
                <asp:HyperLinkField DataNavigateUrlFields="r" 
                    DataNavigateUrlFormatString="get_to_post_app.aspx?mode=edi&amp;rp={0}" 
                    HeaderText="دکمه ویرایش" Text="ویرایش" />
                <asp:HyperLinkField DataNavigateUrlFields="r,paper_link,img" 
                    DataNavigateUrlFormatString="del_posts.aspx?r={0}&amp;link={1}&amp;img={2}&amp;posttype=app" 
                    HeaderText="حذف محصول" Text="حذف" />
            </Columns>
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ModernPlusConnectionString %>" 
            DeleteCommand="DELETE FROM [tbl_app] WHERE [r] = @r" 
            InsertCommand="INSERT INTO [tbl_app] ([title], [name], [type], [price], [text_boy], [date], [time], [like_code], [telegram], [meta_title], [meta_desc], [paper_cmt], [paper_link], [img], [visit_number]) VALUES (@title, @name, @type, @price, @text_boy, @date, @time, @like_code, @telegram, @meta_title, @meta_desc, @paper_cmt, @paper_link, @img, @visit_number)" 
            ProviderName="<%$ ConnectionStrings:ModernPlusConnectionString.ProviderName %>" 
            SelectCommand="SELECT [r], [title], [name], [type], [price], [text_boy], [date], [time], [like_code], [telegram], [meta_title], [meta_desc], [paper_cmt], [paper_link], [img], [visit_number] FROM [tbl_app]" 
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
    </p>
    </form>
</body>
</html>
