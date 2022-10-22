<?php

$Stname = $_POST['Sname'];
$StId = $_POST['SId'];
$Email = $_POST['email'];
$Pnumber = $_POST['phone1'];
$Gnumber = $_POST['phone'];
$Bfor1 = $_POST['booking'];
$Sstart = $_POST['select1'];
$Sending = $_POST['select2'];
$Bfor2 = $_POST['booking1'];

if (!empty($Stname) || !empty($StId) || !empty($Email) || !empty($Pnumber) || !empty($Gnumber) || !empty($Bfor1) || !empty($Sstart) || !empty($Sending) || !empty($Bfor2)) {

$host = "localhost";
$dbUsername = "root";
$dbpassword = "";
$dbname="van";

$conn = new mysqli($host, $dbUsername, $dbpassword, $dbname);

if (mysqli_connect_error())
{
die('Connect Error('. mysqli_connect_error() .')'. mysqli_connect_error());
}
else
{
$SELECT = "SELECT email From vanbooking Where email = ? Limit 1";
$INSERT = "INSERT Into vanbooking (Stname, StId, Email, Pnumber, Gnumber, Bfor1, Sstart, Sending, Bfor2) values(?, ?, ?, ?, ?, ?, ?, ?, ?)";

$stmt = $conn->prepare($SELECT);
$stmt->bind_param("s", $email);
$stmt->execute();
$stmt->bind_result($email);
$stmt->store_result();
$rnum = $stmt->num_rows;

if($rnum==0)
{
$stmt->close();

$stmt = $conn->prepare($INSERT);
$stmt->bind_param("sssiissss", $Stname, $StId, $Email, $Pnumber, $Gnumber, $Bfor1, $Sstart, $Sending, $Bfor2);
$stmt->execute();
echo "Your record inserted successfully!";
}
else
{
echo "Record doesn't inserted";
}
$stmt->close();
$conn->close();
}

}
else
{
echo "All field are required";
die();
}

?>