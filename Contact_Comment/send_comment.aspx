<!DOCTYPE html>
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="send_comment.aspx.cs" Inherits="Contact_Comment_send_comment" %>
<head runat="server">
    <title></title>
    <link href="../assets/css/min.css" rel="stylesheet">
    <style>
        button, input
        {
            float: right;
            direction: rtl;
        }
        
        label
        {
            float: right;
            font-family: Arial;
            font-size: 20px;
        }
        @media (max-width: 1220px)
        {
            .fl_ll
            {
                float: right;
                width: 90%;
            }
        }
        #p_cmt
        {
            direction: rtl;
            margin-bottom: 50px;
        }
        #txt_cmt
        {
            direction: rtl;
            font-size: 20px;
            float: right;
            height: 127px;
        }
        label{direction:rtl;}
        body
        {
            padding:20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="form-group">
        <label for="InputName1">
            نام</label>
        <asp:TextBox class="form-control" ID="name_txt" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="InputEmail1">
            ایمیل 
        </label>
        <asp:TextBox class="form-control" ID="mail_txt" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="message1">
            پیام شما</label>
        <asp:TextBox ID="txt_cmt" class="form-control" runat="server" TextMode="SingleLine"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Button ID="btn_send" runat="server" Text="تأیید و ارسال" class="btn btn-theme fl" />
    </div>
    <div class="form-group" style="visibility:hidden;">
        <label for="message1">
            &ensp;</label>
        <p>
            &ensp;</p>
        <asp:TextBox ID="TextBox1" class="form-control" runat="server"></asp:TextBox>
    </div>
    </form>
    <p class="pt1 fl" id="p_cmt">
        نظرات :
    </p>
</body>
</html>
