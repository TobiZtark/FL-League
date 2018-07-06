<?php
require('connect.php');
require('validate.php');


$reg_date = date("Y-m-d H:i:s");
$last_login = date("Y-m-d H:i:s");
$set = "SELECT * FROM User WHERE username ='$username'";
$check = $conn->query($set);
$numrows = mysqli_num_rows($check);

if ($numrows != 0)
{	
die("User already exists!");
}
else 
{
$pass = md5($password);
$sql = "INSERT INTO User (username, password, pass, email, phone, last_login, reg_date)
VALUES ('$username', '$pass', '$password','$email','$phone','$last_login','$reg_date')";
$reg = $conn->query($sql);

}
if ($reg === TRUE) {
   echo "New record created successfully\n";
	}
	else {
	echo "Error: " . $conn->error;
}

	$email_to = $email;
	$email_subject = "LOG LORDS LOGIN DETAILS";
	$msg= "Hello,\n Thank you for registering with LOG LORDS, your GameID and password is displayed below.\n	GameID: " .$username. "\n	PassCode: " .$password. "\n Please keep confidential.\n Thank you.\n\n\n  Regards,\n The Log Lords Team ";
	$headers = "From: LOG LORDS TEAM\r\n". "Reply-To: adegbenrooluwatobiloba@gmail.com\r\n'" . "X-Mailer: PHP/" . phpversion();
	$send = mail($email_to, $email_subject, $msg, $headers);

if ($send === TRUE)
	{
	die ("Check your email for login details");
}
else
{
	die("Message not sent");
} 

$conn->close();


?>