<?php


// sql to create table
$sql = "CREATE TABLE IF NOT EXISTS User (
user_id INT(11) NOT NULL UNSIGNED AUTO_INCREMENT PRIMARY KEY, 
username VARCHAR(15) NOT NULL,
password VARCHAR(255) NOT NULL,
pass VARCHAR(255) NOT NULL,
email VARCHAR(99) NOT NULL,
phone VARCHAR(28) NOT NULL,
gender ENUM ('M','F') DEFAULT M,
role ENUM ('N','A') DEFAULT N,
user_level VARCHAR(11),
reg_date TIMESTAMP,
last_login TIMESTAMP,
status VARCHAR(90)
)ENGINE=InnoDB";

if ($conn->query($sql) === TRUE) {
    echo "Table User created successfully";
} else {
    echo "Error creating table: " . $conn->error;
}

$conn->close();
?>