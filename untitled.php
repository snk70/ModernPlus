

﻿<!DOCTYPE html>
<html lang="fa">
<head>
    
    


    <link href="../assets/css/min.css" rel="stylesheet">
    <link rel="shortcut icon" href="../assets/img/favicon.ico">
</head>
<body>
    
<div class="navbar navbar-default navbar-fixed-top" role="navigation" >
    
    
      <div class="container">
        <div class="navbar-header">
          <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
            <span class="sr-only">Toggle navigation</span>
            <span class="icon-bar">

</span>
            <span class="icon-bar">

</span>
            <span class="icon-bar">

</span>
          </button>
          <a class="navbar-brand fl_n" target="_blank" href="#">

<div class="img_logo"></div>

</a>
        </div>
        <div class="navbar-collapse collapse navbar-right" style="direction:rtl;">
          <ul class="nav navbar-nav" >
                <li>

<a href="app_market.php">فروشگاه نرم افزار</a>

</li>
                <li>

<a href="articles.php">مطالب</a>

</li>
          <li>

<a href="contact.html" >تماس با ما</a>

</li>
          	<li>

<a href="about.html">درباره ما</a>

</li>
            <li>

<a href="index.php">صفحه اصلی</a>

</li>
            
            
           </ul>
        </div>

<!--/.nav-collapse -->
      </div>
      
      
</div>
    


                        



    

    
    
    

    

    
    <div class="container wdt_100">
        <div class="prp_content" id="prp_content">
            

        </div>
        <div class="side_menu" id="side_menu">
            

        </div>
        <div class="dv_center">
            

        </div>
    </div>

    
<div id="footerwrap">
    <div class="container">
        <div class="row">
            <div class="col-lg-4 fl">
                <h4>
                    درباره ما</h4>
                <div class="hline-w">
                </div>
                <p>
                    تیم توسعه دهنده نرم افزار مدرن پلاس ارائه دهنده خدمات : طراحی و پشتیبانی وب سایت
                    ، سئو و بهینه سازی ، طراحی و ساخت نرم افزار اندروید و ویندوز .</p>
                <a href="../about.html">
                    <p>
                        بیشتر ...</p>
                </a>
            </div>
            <div class="col-lg-4 fl">
                <h4>
                    تماس با ما</h4>
                <div class="hline-w">
                </div>
                <a href="http://www.telegram.me/snk70">
                    <p>
                        شماره 1 : 09127014775</p>
                </a><a href="http://www.telegram.me/S021A">
                    <p>
                        شماره 2 : 09373402001</p>
                </a><a>
                    <p >
                        ایمیل : modernplus.team@yahoo.com</p>
                </a><a href="../contact.html">
                    <p>
                        ارسال پیام خصوصی برای ما</p>
                </a>
            </div>
            <div class="col-lg-4 fl">
                <h4>
                    دسترسی سریع</h4>
                <div class="hline-w">
                </div>
                <a href="../order.html">
                    <p>
                        ثبت سفارش</p>
                </a><a href="../app_market.php">
                    <p>
                        فروشگاه اپلیکیشن های اندروید</p>
                </a><a href="../articles.php">
                    <p>
                        بخش مطالب و دانستنی ها</p>
                </a>
            </div>
        </div>
        <!-- --/row ---->
    </div>
    <!-- --/container ---->
</div>

    <script src="../assets/js/jquery11.min.js">
    </script>
    <script src="../assets/js/bootstrap.min.js">

    </script>
    <script src="../assets/js/jquery.hoverex.min.js">

    </script>
    <script src="../assets/js/jquery.prettyPhoto.js">

    </script>
    <script src="../assets/js/jquery.isotope.min.js">

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
</body>
</html>
