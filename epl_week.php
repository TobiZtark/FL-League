<?php

$eplweek=$laweek=$bundweek=$saweek="";


function test_input($data) {
  $data = strtolower($data);
  $data = trim($data);
  $data = stripslashes($data);
  $data = htmlspecialchars($data);
  return $data;
}
if ($_SERVER["REQUEST_METHOD"] == "POST") {
  $eplweek = test_input($_POST["eplweek"]);
  $laweek = test_input($_POST["laweek"]);
  $bundweek = test_input($_POST["bundweek"]);
  $saweek = test_input($_POST["saweek"]);
  
  foreach (var i in eplweek)
  {
  echo "Recieved ". ($_POST["eplweek"]);
  }
}


?>