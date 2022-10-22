<?php
//checking connection and session start
include "../../connection_files/connection.php";
?>
<?php
//redirecting unauthorized admins
if(!isset($_SESSION['admin-pin']))
{
    header("location:../../Login/logIn.php");
}
?>
<?php
$item_id=$_SESSION['item_id'];
$new_name=mysqli_real_escape_string($connection,$_POST['it_name']);
$new_details=mysqli_real_escape_string($connection,$_POST['details']);
$new_price=mysqli_real_escape_string($connection,$_POST['price_area']);


if ($_FILES['cp']['size'] != 0)
{
//update with cover photo image
    $new_cover = addslashes(file_get_contents($_FILES['cp']['tmp_name']));
    $update_sql="UPDATE items SET item_name='$new_name',description='$new_details',picture='$new_cover',price='$new_price' WHERE item_id='$item_id'";
    $result=mysqli_query($connection,$update_sql);
    if($result)
    {
        $_SESSION['published_msg']="Item has been successfully Updated!!!!";
        $_SESSION['published_msg_type']="success";
        unset($_SESSION['item_id']);
        header("location:manage_events.php");
    }
    else
    {
        $_SESSION['published_msg']="Uploaded Image doesn't Support....or ".$connection->error;
        $_SESSION['published_msg_type']="danger";
        unset($_SESSION['item_id']);
        header("location:manage_events.php");
    }


}
else
{
    //update without cover photo image
    $update_sql="UPDATE items SET item_name='$new_name',description='$new_details',price='$new_price' WHERE item_id='$item_id'";
    $result=mysqli_query($connection,$update_sql);
    if($result)
    {
        $_SESSION['published_msg']="item has been successfully Updated!!!!";
        $_SESSION['published_msg_type']="success";
        unset($_SESSION['item_id']);
        header("location:manage_events.php");
    }
    else
    {
        $_SESSION['published_msg']="Uploaded Image doesn't Support....or ".$connection->error;
        $_SESSION['published_msg_type']="danger";
        unset($_SESSION['item_id']);
        header("location:manage_events.php");
    }


}

?>

