<?php
require('connect.php');

$sql = "CREATE TABLE IF NOT EXISTS LALIGA (
laliga_id INT(15) NOT NULL, 
user_id INT (11) UNSIGNED NOT NULL,
season INT (4),
matchweek INT (2),
lasarray VARCHAR(510) NOT NULL,

PRIMARY KEY(laliga_id),
FOREIGN KEY(user_id) REFERENCES User(user_id) 
)ENGINE=InnoDB";


if ($conn->query($sql) === TRUE) {
    echo "Table LALIGA created successfully";
} else {
    echo "Error creating table: " . $conn->error;
}

$conn->close();

?>