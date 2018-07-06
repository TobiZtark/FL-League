<?php
require('connect.php');

$sql = "DROP TABLE User,EPL,LALIGA,BUNDESLIGA, SERIEA";

if ($conn->query($sql) === TRUE) {
    echo "Table User deleted";
} else {
    echo "Error deleting table: " . $conn->error;
}

$conn->close();

?>