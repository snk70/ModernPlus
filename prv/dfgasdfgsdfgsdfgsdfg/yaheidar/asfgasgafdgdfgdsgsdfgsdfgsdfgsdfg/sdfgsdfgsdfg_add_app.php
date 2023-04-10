<?php
error_reporting(0);
if(isset($_POST["sgsjkdgjsdfg"]) && $_POST["sgsjkdgjsdfg"]=="sdgsdfgsirdgenrgernger")
{


include('../../../config_apps.php');
mysql_query("SET NAMES 'utf8'", $link);
mysql_query("SET CHARACTER SET 'utf8'", $link);
mysql_query("SET character_set_connection = 'utf8'", $link);


$Text_Query="INSERT INTO `tbl_apps` (`Row`, `Name`, `title`, `post_link`, `image_address`, `app_type`, `comment`, `gheymat`) VALUES (NULL, '".$_POST["name"]."', '".$_POST["title"]."', '".$_POST["link"]."', '".$_POST["img"]."', '".$_POST["type"]."', '".$_POST["cmt"]."', '".$_POST["prc"]."')";


mysql_query($Text_Query,$link);
echo("o");
}
elseif(isset($_POST["sgsjkdgjsdfg"]) && $_POST["sgsjkdgjsdfg"]=="del" && isset($_POST["del_r"]))
{
	include('../../../config_apps.php');
	mysql_query("Delete From `tbl_apps` Where(`post_link`='".$_POST["del_r"]."')",$link);
	echo("o");
}
else
{
header('location:/Error.html');	
}

?>