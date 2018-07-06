<?php
require('connect.php');

$sql = "CREATE TABLE IF NOT EXISTS SERIEA (
sa_id INT(15) NOT NULL, 
user_id INT (11) UNSIGNED NOT NULL,
season INT (4),
matchweek INT (2),
saarray VARCHAR(510) NOT NULL,

PRIMARY KEY(sa_id),
FOREIGN KEY(user_id) REFERENCES User(user_id) 
)ENGINE=InnoDB";


if ($conn->query($sql) === TRUE) {
    echo "Table SERIEA created successfully";
} else {
    echo "Error creating table: " . $conn->error;
}

$conn->close();

?>