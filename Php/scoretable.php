<?php
require('connect.php');

$sql = "CREATE TABLE IF NOT EXISTS Score (
score_id INT(11) NOT NULL, 
user_id INT (11) UNSIGNED NOT NULL,
season TIMESTAMP,
matchweek TIMESTAMP,
superscore_id INT(11) NOT NULL,
eplscore_id INT(11) NOT NULL,
lascore_id INT(11) NOT NULL,
bundscore_id INT(11) NOT NULL,
sascore_id INT(11) NOT NULL,
mscore_id INT(11) NOT NULL,
sscore_id INT(11) NOT NULL,
PRIMARY KEY(score_id),
FOREIGN KEY(user_id) REFERENCES User(user_id) 
)ENGINE=InnoDB";


if ($conn->query($sql) === TRUE) {
    echo "Table Score created successfully";
} else {
    echo "Error creating table: " . $conn->error;
}

$conn->close();

?>