<?php
// define variables and set to empty values
$eplresult= $laresult= $bundresult= $saresult= $username =  "";


function test_input($data) {
  $data = strtolower($data);
  $data = trim($data);
  $data = stripslashes($data);
  $data = htmlspecialchars($data);
  return $data;
}
if ($_SERVER["REQUEST_METHOD"] == "POST") {
  $username = test_input($_POST["username"]);

}
if ($_SERVER["REQUEST_METHOD"] == "POST") {
  $eplresult = test_input($_POST["eplresult"]);

}
if ($_SERVER["REQUEST_METHOD"] == "POST") {
  $laresult = test_input($_POST["laresult"]);

}
if ($_SERVER["REQUEST_METHOD"] == "POST") {
  $bundresult = test_input($_POST["bundresult"]);

}
if ($_SERVER["REQUEST_METHOD"] == "POST") {
  $saresult = test_input($_POST["saresult"]);

}

?>