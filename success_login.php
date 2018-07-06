<?php
require ('admin.php');
session_start();
if( !isset( $_SESSION['username'] ) ){
header("location:index.html");
}
	
header("location:dashboard.html");

?>