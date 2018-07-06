<?php
require('connect.php');

function test_input($data) {
  $data = strtolower($data);
  $data = trim($data);
  $data = stripslashes($data);
  $data = htmlspecialchars($data);
  return $data;
}
if ($_SERVER["REQUEST_METHOD"] == "POST") {
  $username = test_input($_POST["username"]);
  $password = test_input($_POST["password"]);

}
$last_login = date("Y-m-d H:i:s");
$set = "SELECT * FROM User WHERE username ='".$username."'" ;
$check = $conn->query($set);
$numrows = mysqli_num_rows($check);
if ($numrows ==0)
{
	die ("GameID does not exist \n");
}
if ($numrows == 1)
{	

	$pass = md5($password);
	while($row = $check->fetch_assoc())
{	//echo "id: " . $row["id"]. " - Name: " . $row["username"]. " " . $row["password"]. "\n";
	//echo $pass."\n";
		if ($pass == $row["password"])
			
{
	echo "Log in successful!";
		$sql = "UPDATE User SET last_login ='$last_login' WHERE username ='".$username."'";
	    $login_time = $conn->query($sql);
}
else
{
 die("Password does not match \n");

}

}
}


?>