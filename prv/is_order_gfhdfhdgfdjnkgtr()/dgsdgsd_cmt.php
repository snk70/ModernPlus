<?php
error_reporting(0);
if($_POST["ya_ali"]=="sina")
{
include('../config_apps.php');
mysql_query("SET NAMES 'utf8'", $link);
mysql_query("SET CHARACTER SET 'utf8'", $link);
mysql_query("SET character_set_connection = 'utf8'", $link);
$rw=mysql_query("SELECT flag FROM `tbl_comments` WHERE(flag='0')",$link);

echo(mysql_num_rows($rw));
}else
{
	header("header:index.php");
}

?>