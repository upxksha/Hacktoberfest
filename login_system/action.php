<?php
//checking the connection
include "connection.php";

$username=$_REQUEST['uname'];
$password=$_REQUEST['pword'];
$empty=array();

//checking for empty inputs (php validations)
if(empty($username)) {array_push($empty,"empty username");}
if(empty($password)) {array_push($empty,"empty password");}

if(count($empty)==0) {

     //getting encrypted password
    $enc_pword= sha1($password);
    //query for check users in database
    $user_check="SELECT * FROM users WHERE username = '$username' AND password= '$enc_pword' LIMIT 1";
    $result= mysqli_query($connection,$user_check);

    if($result)
    {
        if(mysqli_num_rows($result)==1)
        {
            //if result == 1 row ,getting that raw to an array

            //checking user or admin
            $row=mysqli_fetch_assoc($result);
            if($row['username']=="admin")
            {
                //creating a session
                $_SESSION['username_logged']=$username;
                header("location:../admin.php");//add your file path
            }
            else
            {
                $_SESSION['username_logged']=$username;
                header("location:../home.php");//add your file path
            }

        }
        else
        {
            header("location:LogIn.html");
        }

    }else {echo "<b>Error!!!!!</b><br>Can't Check users in database.......".$connection->error;}

}else {echo "<b>Username or Password empty.......</b>";}

?>