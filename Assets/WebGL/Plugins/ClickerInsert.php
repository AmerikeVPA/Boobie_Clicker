<?php
$servername  "localhost";
$username = "D1ck";
$password = "80085";
$dbname = "BoobieClicker";
// get parameters from URL
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

$sql = "INSERT INTO users (user, gender, money, images)
VALUES ($user, $gender, $money, $images)";

if ($conn->query($sql) === TRUE) {
  echo "New record created successfully";
} else {
  echo "Error: " . $sql . "<br>" . $conn->error;
}

$conn->close();
?>