<?php
// define variables and set to empty values
$username = $email = $password =  "";


function test_input($data) {
  $data = strtolower($data);
  $data = trim($data);
  $data = stripslashes($data);
  $data = htmlspecialchars($data);
  return $data;
}
if ($_SERVER["REQUEST_METHOD"] == "POST") {
  $username = test_input($_POST["username"]);
  $email = test_input($_POST["email"]);
   if (!filter_var($email, FILTER_VALIDATE_EMAIL) === false) {
  echo("Email accepted");
  $email = $email;
} else {
  die("Email not Valid");
}
  $password = test_input($_POST["password"]);
  $phone = test_input ($_POST["phone"]);
}


?>