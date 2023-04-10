<?php
error_reporting(0);
$tbl_cmt="tbl_cmt_code";
?>
<!DOCTYPE html>
<html lang="fa">
    <head>
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <title>title_paper</title>



<meta http-equiv="Content-Language" content="fa">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<META NAME="description" CONTENT="meta_desc">
<META NAME="keywords" CONTENT="meta_keywords">

    <!-- Bootstrap core CSS -->
    

    <!-- Custom styles for this template -->
    <link href="../../assets/css/min.css" rel="stylesheet">
    
<link rel="shortcut icon" href="../../assets/img/favicon.ico">
  

  </head>


  <body style="background-color:#f5f3f0;">

    <!-- Fixed navbar -->
    <div class="navbar navbar-default navbar-fixed-top" role="navigation" >
    
    
      <div class="container">
        <div class="navbar-header">
          <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
            <span class="sr-only">Toggle navigation</span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
          </button>
          <a class="navbar-brand fl_n" target="_blank" href="#"><img class="img_logo" src="../../assets/img/logo.png"></a>
        </div>
        <div class="navbar-collapse collapse navbar-right" style="direction:rtl;">
          <ul class="nav navbar-nav" >
                <li><a href="../../app_market.php">فروشگاه نرم افزار</a></li>
                <li><a href="../../articles.php">مطالب</a></li>
          <li><a href="../../contact.html" >تماس با ما</a></li>
          	<li><a href="../../about.html">درباره ما</a></li>
            <li><a href="../../index.php">صفحه اصلی</a></li>
            
            
           </ul>
        </div><!--/.nav-collapse -->
      </div>
      
      
    </div>

	<!-- *****************************************************************************************************************
	 BLUE WRAP
	 ***************************************************************************************************************** -->
		<div id="blue">
	    <div class="container">
			<div class="row">
				<h1>title_paper</h1>
			</div><!-- /row -->
	    </div> <!-- /container -->
	</div><!-- /blue -->

	 
	<!-- *****************************************************************************************************************
	 BLOG CONTENT
	 ***************************************************************************************************************** -->

	
<div class="container wdt_100">
        <p class="p_br_1">&ensp;</p>
    <p class="p_br_1">&ensp;</p>
    

<div class="prp_content" id="prp_content">
text_body_paper
</div>

		
<div class="side_menu" id="side_menu">
<?php
include('../../prv/side_console_bar_menu.html');
?>      
</div>
         		
     <br /><p>&ensp;</p><p>&ensp;</p>
           
          <div class="dv_center">
 <br /><p>&ensp;</p><p>&ensp;</p>
 <div class="hline"></div>
 
           <form id="frm1" action="../../save_comments/Default.aspx" method="post">
           <form id="frm1" action="../../save_comments/Default.aspx" method="post">
<p class="pt1">دیدگاه خود را ثبت نمایید </p>  





					  <div class="form-group">
					    <label for="InputName1">نام</label>
					    <input class="form-control" id="exampleInputEmail1" name="name">
					  </div>
					  <div class="form-group">
					    <label for="InputEmail1">ایمیل</label>
					    <input class="form-control" id="exampleInputEmail1" name="mail" >
					  </div>
					  
					  <div class="form-group">
					  	<label for="message1">پیام شما</label><br><br>
					  	<textarea class="form-control fl" id="message1" rows="3" style="direction:rtl;max-height:500px;font-size:20px;" name="cmt"></textarea>
					  </div><br><br><br><br><br>
					  <button type="submit" class="btn btn-theme fl">تأیید و ارسال</button>

<input class="hd" name="tb" value="tbl_cmt_code">

					</form>
                    
                    
                    
            

<br><br><br><br><br><br><br> <p class="pt1">نظرات : </p><br><br><p>&ensp;</p>
 
 

 
 
                  <?php
					
				include('../../prv/config_apps.php');
			
					
				mysql_query("SET NAMES 'utf8'", $link);
				mysql_query("SET CHARACTER SET 'utf8'", $link);
				mysql_query("SET character_set_connection = 'utf8'", $link);
$rows=mysql_query('SELECT `Name`,`comment`,`Date`,`Time` FROM `tbl_comments` WHERE(flag=\'1\' AND tbl_cmt=\''.$tbl_cmt.'\')');
					
					
					while($r=mysql_fetch_assoc($rows))
					{
						echo('<pre class="dv_cmt"></pre>');
						
						echo('<a class="cmt">'.$r["Name"].'&ensp;&ensp;&ensp;&ensp;'.$r["Date"].'&ensp;-&ensp;'.$r["Time"].'</a><div class="ds"></div>');
						
						echo('<p><div class="dv_opn"><p class="cmt">'.$r["comment"].'</p></div></p>');
					}	



?>
                
                </div>
                
                
                
	
	 		
	 		
	 		<! -- SIDEBAR -->

	 </div><! --/container -->


	<!-- *****************************************************************************************************************
	 FOOTER
	 ***************************************************************************************************************** -->
	 <div id="footerwrap">
	 	<div class="container">
        
        
		 	<div class="row">
		 		<div class="col-lg-4 fl">
		 			<h4>درباره ما</h4>
		 			<div class="hline-w"></div>
		 			<p>تیم توسعه دهنده نرم افزار مدرن پلاس ارائه دهنده خدمات : طراحی و پشتیبانی وب سایت ، سئو و بهینه سازی ، طراحی و ساخت نرم افزار اندروید و ویندوز .</p>
		 		<a href="../../about.html"><p>بیشتر ...</p></a>
                </div>
		 	
            
            
            <div class="col-lg-4 fl">
		 			<h4>تماس با ما</h4>
		 			<div class="hline-w"></div>
		 	<a href="http://www.telegram.me/snk70"><p>شماره 1 : 09127014775</p></a>
            <a href="http://www.telegram.me/S021A"><p>شماره 2 : 09373402001</p></a>
               <a><p>ایمیل : modernplus.team@yahoo.com</p></a>
                
                <a href="../../contact.html"><p>ارسال پیام خصوصی برای ما</p></a>
                
                
		 		</div>
                
                     <div class="col-lg-4 fl">
		 			<h4>دسترسی سریع</h4>
		 			<div class="hline-w"></div>
		 
         <a href="../../order.html"><p>ثبت سفارش</p></a>
         <a href="../../app_market.php"><p>فروشگاه اپلیکیشن های اندروید</p></a>
         <a href="../../articles.php"><p>بخش مطالب و دانستنی ها</p></a>
         
		 			</div>
                
		
        
        
		 	
		 	</div><! --/row -->
	 	</div><! --/container -->
	 </div><! --/footerwrap -->
	  <script type="text/javascript">
     
     
     function srch()
	 {
		 
		 
 var str=		document.getElementById('txt_search').value; 
		 
		 window.open("https://www.google.com/search?client=opera&q=site%3Amodernplus.ir+"+str+"&sourceid=opera&ie=UTF-8&oe=UTF-8");
		 
		 
		 
	 }
     
     
     </script>
    <!-- Bootstrap core JavaScript
    ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    <script src="../../assets/js/jquery11.min.js"></script>
    <script src="../../assets/js/bootstrap.min.js"></script>
	
	
	<script src="../../assets/js/jquery.hoverex.min.js"></script>
	<script src="../../assets/js/jquery.prettyPhoto.js"></script>
  	<script src="../../assets/js/jquery.isotope.min.js"></script>
  	


  </body>
</html>
 