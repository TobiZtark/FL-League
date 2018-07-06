<?php
require ('connect.php');


$sql = "SELECT * FROM User";
$test = $conn->query($sql);

 while($row = $test->fetch_assoc())
      {
      //echo $row['epl_id'] . " " . $row['user_id']. " " . $row['season']. " " . $row['matchweek']. " " . $row['eplarray']; 
	  echo "id: " . $row["user_id"]. " " . "user id: ". $row["username"]. " " . "Reg Date: ". $row["reg_date"]. " " . "Password: ". $row["password"]. " " . "Result: ". $row["pass"];
      echo "<br />";
      }


?>