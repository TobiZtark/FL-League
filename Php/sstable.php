<?php
require('connect.php');

$sql = "CREATE TABLE IF NOT EXISTS SSPECIALS (
ss_id INT(15) NOT NULL, 
user_id INT (11) UNSIGNED NOT NULL,
season INT(4),
teplarray VARCHAR(510) NOT NULL,
leplarray VARCHAR(510) NOT NULL,
feplarray VARCHAR(510) NOT NULL,
tlaarray VARCHAR(510) NOT NULL,
llaarray VARCHAR(510) NOT NULL,
flaarray VARCHAR(510) NOT NULL,
tbundarray VARCHAR(510) NOT NULL,
lbundarray VARCHAR(510) NOT NULL,
fbundarray VARCHAR(510) NOT NULL,
tsaarray VARCHAR(510) NOT NULL,
lsaarray VARCHAR(510) NOT NULL,
fsaarray VARCHAR(510) NOT NULL,

PRIMARY KEY(ss_id),
FOREIGN KEY(user_id) REFERENCES User(user_id) 
)ENGINE=InnoDB";


if ($conn->query($sql) === TRUE) {
    echo "Table SSPECIALS created successfully";
} else {
    echo "Error creating table: " . $conn->error;
}

$conn->close();

?>