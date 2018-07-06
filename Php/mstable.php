<?php
require('connect.php');

$sql = "CREATE TABLE IF NOT EXISTS MSPECIALS (
ms_id INT(11) NOT NULL, 
user_id INT (11) UNSIGNED NOT NULL,
season INT (4),
month INT (2),
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

PRIMARY KEY(ms_id),
FOREIGN KEY(user_id) REFERENCES User(user_id) 
)ENGINE=InnoDB";


if ($conn->query($sql) === TRUE) {
    echo "Table MSPECIALS created successfully";
} else {
    echo "Error creating table: " . $conn->error;
}

$conn->close();

?>