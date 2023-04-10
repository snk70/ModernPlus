<!DOCTYPE html>
<html lang="fa">
  <head>    
<meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">


<meta http-equiv="Content-Language" content="fa">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<META NAME="Description" CONTENT="فروشگاه اپلیکیشن های اندرویدی, دانلود اپلیکیشن های اندروید, دانلود برنامه های اندروید, دانلود نرم افزار برای موبایل, اپلیکیشن های موبایل, برنامه های گوشی">
<META NAME="Keywords" CONTENT="فروشگاه, اپلیکیشن اندروید, فروش اپلیکیشن, فروشگاه اپ, دانلود برنامه اندروید">

   

    <title>فروشگاه نرم افزاری مدرن پلاس | دانلود اپلیکیشن های اندروید</title>

    <!-- Bootstrap core CSS -->
    

    <!-- Custom styles for this template -->
    <link href="assets/css/min.css" rel="stylesheet">
    

<link rel="shortcut icon" href="assets/img/favicon.ico">
    

    
    

  
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
          <a class="navbar-brand fl_n" target="_blank" href="#"><img class="img_logo" src="assets/img/logo.png"></a>
        </div>
        <div class="navbar-collapse collapse navbar-right" style="direction:rtl;">
          <ul class="nav navbar-nav" >
                <li class="active"><a href="app_market.php">فروشگاه نرم افزار</a></li>
                <li><a href="articles.php">مطالب</a></li>
          <li><a href="contact.html" >تماس با ما</a></li>
          	<li><a href="about.html">درباره ما</a></li>
         <li><a href="index.php">صفحه اصلی</a></li>
            
            
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
				<h1>فروشگاه نرم افزاری مدرن پلاس			</ha>
			</div>
			<!-- /row -->
	    </div> <!-- /container -->
	</div><!-- /blue -->

	 
	<!-- *****************************************************************************************************************
	 BLOG CONTENT
	 ***************************************************************************************************************** -->
     

<div class="container wdt_100">
        <p class="p_br_1">&ensp;</p>
    <p class="p_br_1">&ensp;</p>
    

<div class="prp_content" id="prp_content" style="background-color:#f5f3f0;padding:0;">
        
       
                  <?php

		   include('prv/config_apps.php');
		   mysql_query("SET NAMES 'utf8'", $link);
		   mysql_query("SET CHARACTER SET 'utf8'", $link);
		   mysql_query("SET character_set_connection = 'utf8'", $link);

if(isset($_GET["sort_v"]))
{
				$rows2=mysql_query('SELECT * FROM `tbl_apps` ORDER BY `Row` DESC',$link);
				$lvl=0;
				while($r2=mysql_fetch_assoc($rows2))
				{
					$lvl++;
					if($lvl<=$_GET["sort_v"]*9 && $lvl>($_GET["sort_v"]-1)*9)
					{
			   echo('<a href="posts/'.$r2["post_link"].'"><div class="fl item_content">');
			   echo('<p class="ptt1">'.$r2["Name"].'</p>');
			   echo('<p class="ptt1 fl_l">'.$r2["gheymat"].'</p>');
			   echo('<img src="assets/img/portfolio/'.$r2["image_address"].'" class="img_prd">');
			   echo('<div class="prt_prd_comments"><p class="pt2">'.$r2["title"].'</p><p class="pt5">'.$r2["comment"].'</p></div>');
			   echo('</div></a>');
					}
				}
				
}else
{
				
			$rw=mysql_query('SELECT * FROM tbl_apps ORDER BY `Row` DESC LIMIT 9');
		   
		   while($r=mysql_fetch_assoc($rw))
		   {
			   
			   echo('<a href="posts/'.$r["post_link"].'"><div class="fl item_content">');
			   echo('<p class="ptt1">'.$r["Name"].'</p>');
			   echo('<p class="ptt1 fl_l">'.$r["gheymat"].'</p>');
			   echo('<img src="assets/img/portfolio/'.$r["image_address"].'" class="img_prd">');
			   echo('<div class="prt_prd_comments"><p class="pt2">'.$r["title"].'</p><p class="pt5">'.$r["comment"].'</p></div>');
			   echo('</div></a>');
		   }
}
		   
		   
		   
		   ?>
        
        
        
        
  

        
        <div class="dv_pages">
         <?php
		
		include('prv/config_apps.php');
		

		$row=mysql_query('SELECT COUNT(Row) FROM `tbl_apps`',$link);
		$rn=mysql_fetch_assoc($row);
		if($rn["COUNT(Row)"]>9)
		{
			
			for($i=1;$i<ceil($rn["COUNT(Row)"]/9)+1;$i++)
			{
				echo('<a class="cntr" href="?sort_v='.$i.'">'.$i.'</a>&ensp;');
			}
			
		}
		
		?>
        </div>
        
</div>
       <div class="side_menu" id="side_menu">
       	<?php
include('prv/side_console_bar_menu.html');
?>            
       </div>
        
        
		</div>








	<!-- *****************************************************************************************************************
	 FOOTER
	 ***************************************************************************************************************** -->
		 <div id="footerwrap" style="direction:rtl;">
	 	<div class="container" style="direction:rtl;">
        
        
		 	<div class="row" style="direction:rtl;">
		 		<div class="col-lg-4 fl">
		 			<h4>درباره ما</h4>
		 			<div class="hline-w"></div>
		 			<p>تیم توسعه دهنده نرم افزار مدرن پلاس ارائه دهنده خدمات : طراحی و پشتیبانی وب سایت ، سئو و بهینه سازی ، طراحی و ساخت نرم افزار اندروید و ویندوز .</p>
		 		<a href="about.html"><p>بیشتر ...</p></a>
                </div>
		 	
            
            
            <div class="col-lg-4 fl">
		 			<h4>تماس با ما</h4>
		 			<div class="hline-w"></div>
		 	<a href="http://www.telegram.me/snk70"><p>شماره 1 : 09127014775</p></a>
            <a href="http://www.telegram.me/S021A"><p>شماره 2 : 09373402001</p></a>
               <a><p>ایمیل : modernplus.team@yahoo.com</p></a>
                
                <a href="contact.html"><p>ارسال پیام خصوصی برای ما</p></a>
                
                
		 		</div>
                
                     <div class="col-lg-4 fl">
		 			<h4>دسترسی سریع</h4>
		 			<div class="hline-w"></div>
		 
         <a href="order.html"><p>ثبت سفارش</p></a>
         <a href="app_market.php"><p>فروشگاه اپلیکیشن های اندروید</p></a>
         <a href="articles.php"><p>بخش مطالب و دانستنی ها</p></a>
         
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
    <script src="assets/js/jquery11.min.js"></script>
    <script src="assets/js/bootstrap.min.js"></script>
	
	
	<script src="assets/js/jquery.hoverex.min.js"></script>
	<script src="assets/js/jquery.prettyPhoto.js"></script>
  	<script src="assets/js/jquery.isotope.min.js"></script>
  	
        <script type="text/javascript">	
		$(document).ready(function() 
		{
		var item_length=document.getElementsByClassName('item_content').length;
		var biggest_item=0;
		
		for(var i=0;i<item_length;i++)
		{
			if($('.item_content:eq('+i+')').height()>biggest_item)
			{
			if(window.innerWidth>1400)
			{
			var biggest_item=$('.item_content:eq('+i+')').outerHeight()*1.1;
			}else
			{
			var biggest_item=$('.item_content:eq('+i+')').outerHeight()*1.08;	
			}
			}
		}
		
		//alert(biggest_item);
		
	
	
		
		for(var k=0;k<item_length;k++)
		{
			document.getElementsByClassName('item_content').item(k).style.height=biggest_item+"px";
		}
		
		})
        </script>

  </body>
</html>
