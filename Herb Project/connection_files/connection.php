<?php
session_start();
?>
<?php
$host="localhost";
$username="root";
$password="";
$db="medi_db";

$connection = mysqli_connect($host,$username,$password,$db) or die("Sorry!!! Can't Connect to the Database / Error is ".mysqli_connect_error());

?>