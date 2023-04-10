<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Pages/Art_and_App_Master_Page.master"
    AutoEventWireup="true" CodeFile="post_show.aspx.cs" Inherits="Master_Pages_post_show" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cn_Head" runat="Server">
    <%
        Response.Write(cn_Head);
    %>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cn_dv_Blue_For_art_app_Pages" runat="Server">
    <%
        Response.Write(cn_dv_Blue_For_art_app_Pages);
    %>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cn_PRP_Content" runat="Server">
    <%
        Response.Write(cn_PRP_Content);
    %>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cn_Side_Menu" runat="Server">
    <%
        Response.Write(cn_Side_Menu);
    %>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="cn_DV_Center" runat="Server">
    <%
        Response.Write(cn_DV_Center);
    %>
</asp:Content>
