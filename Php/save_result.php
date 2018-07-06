<?php
require('connect.php');
require ('collectresult.php');



$season = date("Y");
$week = date("W");
$sub_date = date("YmdHis");
if($eplresult!= NULL)
{
$sql = "INSERT INTO EPL (epl_id, user_id, season, matchweek, eplarray) VALUES ('$sub_date',(SELECT user_id FROM User WHERE username ='".$username."'),'$season', '$week', '$eplresult')";
}
else if($laresult!= NULL)
{
$sql = "INSERT INTO LALIGA (laliga_id, user_id, season, matchweek, lasarray) VALUES ('$sub_date',(SELECT user_id FROM User WHERE username ='".$username."'),'$season', '$week', '$laresult')";
}
else if($bundresult!= NULL)
{
$sql = "INSERT INTO BUNDESLIGA (bund_id, user_id, season, matchweek, bundarray) VALUES ('$sub_date',(SELECT user_id FROM User WHERE username ='".$username."'),'$season', '$week', '$bundresult')";
}
else if($saresult!= NULL)
{
$sql = "INSERT INTO SERIEA (sa_id, user_id, season, matchweek, saarray) VALUES ('$sub_date',(SELECT user_id FROM User WHERE username ='".$username."'),'$season', '$week', '$saresult')";
}
else die ("No Data Submitted");

$load = $conn->query($sql);

if ($load === TRUE) {
   echo "Submission successful!";
   echo $eplresult;
   
	}
	else {
	echo "Error: " . $conn->error;
}



?>