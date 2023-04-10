<?php
error_reporting(0);
if($_POST["sina"]=="ya_hossein" & isset($_POST["lfgsdjflgkdfghkl"]))
{


$data=array();
include('../config_apps.php');
mysql_query("SET NAMES 'utf8'", $link);
mysql_query("SET CHARACTER SET 'utf8'", $link);
mysql_query("SET character_set_connection = 'utf8'", $link);

$rw=mysql_query("SELECT * FROM `tbl_contact` WHERE(status='0')",$link);

if($_POST["lfgsdjflgkdfghkl"]=="cmt")
{


$x=0;

while($r=mysql_fetch_assoc($rw))
{
	
	$data[$x]=array('name'=>$r["Name"],'mail'=>$r["Email"],'cmt'=>$r["comment"],'date'=>$r["date"]."-".$r["time"]);
	$x++;
	
	
}

echo(json_encode($data));


}elseif($_POST["lfgsdjflgkdfghkl"]=="nym")
{
	echo(mysql_num_rows($rw));
}else
{
header("location:index.php");	
}

}else
{
header("location:index.php");		
}

?>