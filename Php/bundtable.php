<?php
require('connect.php');

$sql = "CREATE TABLE IF NOT EXISTS BUNDESLIGA (
bund_id INT(15) NOT NULL, 
user_id INT (11) UNSIGNED NOT NULL,
season INT (4),
matchweek INT (2),
bundarray VARCHAR(510) NOT NULL,

PRIMARY KEY(bund_id),
FOREIGN KEY(user_id) REFERENCES User(user_id) 
)ENGINE=InnoDB";


if ($conn->query($sql) === TRUE) {
    echo "Table BUNDESLIGA created successfully";
} else {
    echo "Error creating table: " . $conn->error;
}

$conn->close();

?>