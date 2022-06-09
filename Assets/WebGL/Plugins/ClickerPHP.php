<?php
$servername  "localhost";
$username = "D1ck";
$password = "80085";
$dbname = "BoobieClicker";
// get the q parameter from URL
$gender = $_REQUEST["g"];
$user = $_REQUEST["u"];
$money = $_REQUEST["m"];
$images = $_REQUEST["i"];
// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);
// Check connection
if ($conn->connect_error) {
  die("Connection failed: " . $conn->connect_error);
}

$sql = "INSERT INTO datos (idDatos, level, points)
VALUES (2, 25, 35)";

if ($conn->query($sql) === TRUE) {
  echo "New record created successfully";
} else {
  echo "Error: " . $sql . "<br>" . $conn->error;
}

$conn->close();
?>