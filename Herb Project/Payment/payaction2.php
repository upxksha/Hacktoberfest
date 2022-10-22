<?php
//checking connection and session start
include "../connection_files/connection.php";
?>
<?php
$name_on_card=$_REQUEST['noc'];
$card_number=$_REQUEST['cnum'];
$username=$_SESSION['username'];

$pay_data_sql="UPDATE payments SET name_on_card='$name_on_card',card_number='$card_number' WHERE username='$username' LIMIT 1";
if($connection->query($pay_data_sql)==true)
{
    header("location:thanku.php");
}
else
{
    echo "Database connection error.............. ".$connection->error;
}