<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<%@ Register src="Master_Pages/Footer_WebUserControl.ascx" tagname="Footer_WebUserControl" tagprefix="uc1" %>
<form id="form1" runat="server">

﻿<!DOCTYPE html>

<html lang="fa">

<head>

<meta http-equiv="X-UA-Compatible" content="IE=edge">

<meta name="viewport" content="width=device-width, initial-scale=1">

<meta http-equiv="Content-Language" content="fa">

<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">

<META NAME="Description" CONTENT="ثبت سفارش ساخت اپلیکیشن اندروید, طراحی اپلیکیشن اندروید, سفارش برنامه اندروید, سفارش ساخت برنامه اندروید, سفارش طراحی سایت, سفارش راه اندازی سایت">

<META NAME="Keywords" CONTENT="سفارش اپلیکیشن, نرم افزار سایخت اپلیکیشن, طراحی سایت, راه اندازی سایت, ساخت سایت, ساخت نرم افزار ویندوز, ثبت سفارش">

<title>مدرن پلاس | طراحی سایت و اپلیکیشن</title>

<link href="assets/css/min.css" rel="stylesheet">

<link rel="shortcut icon" href="assets/img/favicon.ico">

<style>.b{width:150px}.t{line-height:50px;font-size:23px}@media(max-width:800px){.h_mobile1{height:150px}}@media(max-width:430px){.h_mobile1{height:70px}}


</style>

</head>

<body>













<div id="twrap">

<div class="container centered">

</div>

<! --/container -->

</div>

<! --/twrap -->

<div id="cwrap">

<div class="container">

<div class="row centered">

<h3 class="pm1 pc3">با توجه به اهمیت اینترنت در بازاریابی و تبلیغات ، امروزه داشتن یک وب سایت برای کسب و کار های گوناگون یک امر ضروری جهت موفقیت میباشد .</h3>

<h3 class="pm1 pc5">در واقع امروزه شرکت ها و موسساتی که فاقد وب سایت اختصاصی میباشند ، خود را از دید مردم و مشتریان پنهان کرده اند و با افزایش کابران دنیای مجازی از سایر رقبای خود باز خواهند ماند .</h3>

<h3 class="pm1 pc6">با رشد تجارت الکترونیک و و افزایش کاربران دنیای مجازی ، بهره گیری از اپلیکیشن و وب سایت اختصاصی ، تأثیر شگرفی در بازاریابی و تجارت خواهد داشت .</h3>

    <uc1:Footer_WebUserControl ID="Footer_WebUserControl1" runat="server" />

</div>

<! --/row -->

</div>

<! --/container -->

</div>

<! --/cwrap -->

 <script src="assets/js/jquery11.min.js">

</script> <script src="assets/js/bootstrap.min.js">

</script> <script src="assets/js/jquery.hoverex.min.js">

</script> <script src="assets/js/jquery.prettyPhoto.js">

</script> <script src="assets/js/jquery.isotope.min.js">

</script>


    <script>
        // Portfolio
        (function ($) {
            "use strict";
            var $container = $('.portfolio'),
		$items = $container.find('.portfolio-item'),
		portfolioLayout = 'fitRows';

            if ($container.hasClass('portfolio-centered')) {
                portfolioLayout = 'masonry';
            }

            $container.isotope({
                filter: '*',
                animationEngine: 'best-available',
                layoutMode: portfolioLayout,
                animationOptions: {
                    duration: 750,
                    easing: 'linear',
                    queue: false
                },
                masonry: {
            }
        }, refreshWaypoints());

        function refreshWaypoints() {
            setTimeout(function () {
            }, 1000);
        }

        $('nav.portfolio-filter ul a').on('click', function () {
            var selector = $(this).attr('data-filter');
            $container.isotope({ filter: selector }, refreshWaypoints());
            $('nav.portfolio-filter ul a').removeClass('active');
            $(this).addClass('active');
            return false;
        });

        function getColumnNumber() {
            var winWidth = $(window).width(),
			columnNumber = 1;

            if (winWidth > 1200) {
                columnNumber = 5;
            } else if (winWidth > 950) {
                columnNumber = 4;
            } else if (winWidth > 600) {
                columnNumber = 3;
            } else if (winWidth > 400) {
                columnNumber = 2;
            } else if (winWidth > 250) {
                columnNumber = 1;
            }
            return columnNumber;
        }

        function setColumns() {
            var winWidth = $(window).width(),
				columnNumber = getColumnNumber(),
				itemWidth = Math.floor(winWidth / columnNumber);


            for (var x = 0; x < document.getElementsByClassName('dv_item_img').length; x++) {
                document.getElementsByClassName('dv_item_img').item(x).style.width = itemWidth + "px";
                document.getElementsByClassName('dv_item_img').item(x).style.height = (itemWidth * 450 / 600) + "px";
                document.getElementsByClassName('dv_item_img').item(x).style.backgroundSize = "cover";
                document.getElementsByClassName('dv_item_img').item(x).style.backgroundPosition = "center";
            }

            $container.find('.portfolio-item').each(function () {
                $(this).css({
                    width: itemWidth + 'px'




                });
            });
        }

        function setPortfolio() {
            setColumns();
            $container.isotope('reLayout');
        }

        $container.imagesLoaded(function () {
            setPortfolio();
        });

        $(window).on('resize', function () {
            setPortfolio();
        });
    })(jQuery);
</script>
 
 
 
 </form>
 
 
 
 </body>

</html>