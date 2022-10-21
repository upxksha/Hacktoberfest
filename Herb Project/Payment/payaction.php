<?php
include "../connection_files/connection.php";
?>
<?php
$item=$_REQUEST['item'];
$uname=$_REQUEST['uname'];
$amount=$_REQUEST['amount'];
$price=$_REQUEST['price'];
$fname=$_REQUEST['fname'];
$mail=$_REQUEST["mail"];
$add=$_REQUEST['add'];
$city=$_REQUEST['city'];
$country=$_REQUEST['country'];
$zip=$_REQUEST['zip'];


$pay_data_sql="INSERT INTO payments(item,username,amount,price,full_name,e_mail,address,city,country,zip)VALUES('$item','$uname','$amount','$price','$fname','$mail','$add','$city','$country','$zip')";
if($connection->query($pay_data_sql)==true)
{
    header("location:payment2.html");
}
else
{
    echo "Database connection error.............. ".$connection->error;
}
