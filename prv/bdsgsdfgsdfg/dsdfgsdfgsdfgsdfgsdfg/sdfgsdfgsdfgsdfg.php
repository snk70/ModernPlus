<?php
error_reporting(0);

if(isset($_POST["sina"]) && isset($_POST["ya_ali"]) && isset($_POST["gsdfgsdf"]))
{
	$p_sign=$_POST["gsdfgsdf"];
	$p_Market = $_POST["sina"];
	
	Product_Sign($p_sign,$p_Market);
	
}else
{
header('location:/Error.html');	
}

function Product_Sign($Sign,$Market)
{ 
		if($Sign=="easy_vSBeYAv4qn")
		{
			/*
			اگر اوکی بود : عبارت Sign با رمز گذاری بیس 64
			اگر مارکت غیر فعال بود : عبارت d
			14 : اگر رایگان بود خرید
			*/
				if($Market=="mkt_AhDZfyte7q")
				{
					echo("d");	
				}elseif($Market=="inp_Nb6j3uTZpB")
				{
					//echo(base64_encode("3D:45:32:9A:98:E3:FD:09:CD:B8:E0:4F:9A:96:69:B1:6E:95:6D:1E"));
					echo('14');
				}else
				{
				echo("0");	
				}
		}else
		{
		echo("0");	
		}

}
?>