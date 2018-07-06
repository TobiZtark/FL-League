<?php
require('insert.php');
if ($reg === TRUE){
$email_to= $email;
$email_subject="LOG LORDS DETAILS";
$msg= "Hello,\n Thank you for registering with LOG LORDS, your GameID and password is displayed below.\n	GameID: " .$username. "\n	PassCode: " .$password. "\n Please keep confidential.\n Thank you.\n\n\n  Regards,\n The Log Lords Team ";
$email_message= wordwrap($msg,70);
$headers = "From: Beacze\r\n".
"Reply-To: address@gmail.com\r\n'" .
"X-Mailer: PHP/" . phpversion();
mail($email_to, $email_subject, $email_message, $headers);  
echo "mail sent!"
}
else
	die("Message not sent");
?>