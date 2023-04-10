<?php
error_reporting(0);
if(isset($_POST["p_id"]) && isset($_POST["opr"]))
{
		
		if($_POST["p_id"]=="123456")
		{
			if($_POST["opr"]=="1")
			{
				echo("p5wWwWwW");
			}		
			
		}else if($_POST["p_id"]=="131703")
		{
			//سلفی راحت
			if($_POST["opr"]=="1")
			{
				echo("vywWwWwWwW");
			}		
			
		}else if($_POST["p_id"]=="148066")
		{
			//دسترسی سه سوته
			if($_POST["opr"]=="1")
			{
				echo("0ALIwWwWwW");
			}		
			
		}
		
}else
{
header('location:/Error.html');	
}


?>