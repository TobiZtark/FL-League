<?php
require('connect.php');

$sql = "CREATE TABLE IF NOT EXISTS EPL (
epl_id INT(15) NOT NULL, 
user_id INT (11) UNSIGNED NOT NULL,
season INT (4),
matchweek INT (2),
eplarray VARCHAR(510) NOT NULL,

PRIMARY KEY(epl_id),
FOREIGN KEY(user_id) REFERENCES User(user_id) 
)ENGINE=InnoDB";


if ($conn->query($sql) === TRUE) {
    echo "Table EPL created successfully";
} else {
    echo "Error creating table: " . $conn->error;
}

$conn->close();

?>