<?php
$servername = "localhost";
$username = "id1859120_loglords";
$password = "callthepopo";
$dbname = "id1859120_prananetgames";

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);
// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
} 

?>