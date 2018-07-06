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
$set = "SELECT * FROM User WHERE username ='".$username."'";
// AND role ='A'
$check = $conn->query($set);
$numrows = mysqli_num_rows($check);
if ($numrows ==0)
{
	echo "<script language=\"JavaScript\">\n";
	echo "alert('Username is incorrect!');\n";
	echo "window.location='index.html'";
	echo "</script>";
	die;
}
if ($numrows == 1)
{	

	$pass = md5($password);
	while($row = $check->fetch_assoc())
{	
		if ($pass == $row["password"])
			
		{
		echo "<script language=\"JavaScript\">\n";
		echo "alert('Welcome Administrator');\n";
		echo "window.location.href='success_login.php'";
		echo "</script>";
		$_SESSION["username"] = $username;
		$sql = "UPDATE User SET last_login ='$last_login' WHERE username ='".$username."'";
	    $login_time = $conn->query($sql);

		}
		else
		{
		echo "<script language=\"JavaScript\">\n";
		echo "alert('Password does not match');\n";
		echo "window.location='index.html'";
		echo "</script>";
		die;

		}

}
}


?>

