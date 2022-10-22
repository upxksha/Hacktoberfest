<?php
//checking connection and session start
include "../../connection_files/connection.php";
?>
<?php
//Change Password
$current_password=$_REQUEST['current_pword'];
$new_password=$_REQUEST['new_pword'];
$confirm_password=$_REQUEST['confirm_pword'];
$submit_password=$_REQUEST['btn_password'];

if(isset($submit_password))
{
    //checking current password is correct or not
    $enc_curr=sha1($current_password);
    $check="SELECT password FROM users WHERE username='admin' LIMIT 1";
    $result=mysqli_query($connection,$check);
    $value=mysqli_fetch_assoc($result);
    if($value['password']==$enc_curr)
    {

            $enc_pw=sha1($new_password);
            $sql_change_password = "UPDATE users SET password='$enc_pw' WHERE username='admin' LIMIT 1";
            if ($connection->query($sql_change_password) == true) {
                $_SESSION['change_msg']="Admin Account Password Successfully Changed";
                $_SESSION['change_msg_type']="success";
            } else {
                $_SESSION['change_msg']="Error!!!! Can't Change Password....";
                $_SESSION['change_msg_type']="danger";
            }


    }
   else
    {
        $_SESSION['change_msg']="Current Password is invalid, Please check and try again!!!";
        $_SESSION['change_msg_type']="danger";
    }


}

?>
<?php
//Change Admin Pin
$current_pin=$_REQUEST['current_pin'];
$new_pin=$_REQUEST['new_pin'];
$confirm_pin=$_REQUEST['confirm_pin'];
$submit_pin=$_REQUEST['btn_pin'];

if(isset($submit_pin))
{
    //checking current password is correct or not
    $enc_curr_pin=sha1($current_pin);
    $check_pin="SELECT admin_pin FROM users WHERE username='admin' LIMIT 1";
    $result_pin=mysqli_query($connection,$check_pin);
    $value_pin=mysqli_fetch_assoc($result_pin);
    if($value_pin['admin_pin']==$enc_curr_pin)
    {

            $enc_pin=sha1($new_pin);
            $sql_change_pin = "UPDATE users SET admin_pin='$enc_pin' WHERE username='admin' LIMIT 1";
            if ($connection->query($sql_change_pin) == true) {
                $_SESSION['change_msg_pin']="Admin Pin Successfully Changed";
                $_SESSION['change_msg_type_pin']="success";
            } else {
                $_SESSION['change_msg_pin']="Error!!!! Can't Change Admin Pin....";
                $_SESSION['change_msg_type_pin']="danger";
            }


    }
    else
    {
        $_SESSION['change_msg_pin']="Current Admin Pin is invalid, Please check and try again!!!";
        $_SESSION['change_msg_type_pin']="danger";
    }


}

?>

<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" type="text/css" href="admin.css">
    <link rel="stylesheet" type="text/css" href="../bootstrap1.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <script lang="JavaScript" type="text/javascript">
        function ConfLogout() {
            let text = "You will be logged From Admin Account out as a result of this Action.\nContinue the Action?";
            if (confirm(text) == true)
            {
                return true;
            }
        }
    </script>

    <script lang="JavaScript" type="text/javascript" src="credentials.js" >
    </script>
    <link rel="icon" href="logo.jfif">
    <title>Admin Profile (Account Security)</title>

</head>
<body>

<div class="sidenav">
    <div id="div-btn-back">
        <button id="back-btn"><a href="../../home.php"><i class="fa fa-arrow-circle-left" id="icon"></i></a></button>
    </div>
    <img src="admin.png" alt="admin_avatar">
    <h1>ADMINISTRATOR</h1>
    <br><br>
    <a href="admin.php">Manage Users</a><br>
    <a href="manage_events.php">Manage Events</a><br>
    <a href="#" style="color: forestgreen;">Account Security</a>
    <br><br>
    <button id="btnlo" onclick="return ConfLogout()==true"><a href="../logout.php">Logout</a></button>
</div>

<!--Page Content Start-->

<div class="content-admin">
    <?php if(isset($_SESSION['change_msg'])): ?>
        <div class="alert alert-<?=$_SESSION['change_msg_type']?>">
            <?php
            echo $_SESSION['change_msg'];
            unset($_SESSION['change_msg']);
            unset($_SESSION['change_msg_type']);
            ?>
        </div>
    <?php endif; ?>
        <center><br>
<h2>Change Account Password</h2>
    <br>
            <form name="admin_password" method="post" action="credentials.php">
    <table>
        <tr>
            <td style="width: 200px; padding-top: 10px"> <h5>Current Password</h5></td>
            <td><input type="text" name="current_pword" size="30" maxlength="30" placeholder="Enter Current Password"></td>
        </tr>
        <tr>
            <td style="width: 200px; padding-top: 10px"> <h5>New Password</h5></td>
            <td><input type="password" name="new_pword" size="30" maxlength="30" placeholder="Enter New Password"></td>
        </tr>
        <tr>
            <td style="width: 200px; padding-top: 10px"> <h5>Confirm Password</h5></td>
            <td><input type="password" name="confirm_pword" size="30" maxlength="30" placeholder="Confirm New Password"></td>
        </tr>
        <tr>
            <td style="text-align: right;height: 100px;"><input class="btn btn-danger" name="btn_password" type="submit" value="Save Changes" onclick=" return ValidPassword()"></td>
            <td style="text-align: left;height: 100px;padding-left: 25px;"><button class="btn btn-dark" type="reset">Clear</button></td>
        </tr>
    </table>
            </form>
        </center>


    <hr>
    <?php if(isset($_SESSION['change_msg_pin'])): ?>
        <div class="alert alert-<?=$_SESSION['change_msg_type_pin']?>">
            <?php
            echo $_SESSION['change_msg_pin'];
            unset($_SESSION['change_msg_pin']);
            unset($_SESSION['change_msg_type_pin']);
            ?>
        </div>
    <?php endif; ?>
    <br>

        <center>
    <h2>Change Admin Pin</h2>
        <br>
            <form name="admin_pin" method="post" action="credentials.php">
        <table>
            <tr>
                <td style="width: 200px; padding-top: 10px"> <h5>Current Admin Pin</h5></td>
                <td><input type="text" name="current_pin" size="30" maxlength="30" placeholder="Enter Current Pin"></td>
            </tr>
            <tr>
                <td style="width: 200px; padding-top: 10px"> <h5>New Admin Pin</h5></td>
                <td><input type="password" name="new_pin" size="30" maxlength="30" placeholder="Enter New Pin"></td>
            </tr>
            <tr>
                <td style="width: 200px; padding-top: 10px"> <h5>Confirm Admin Pin</h5></td>
                <td><input type="password" name="confirm_pin" size="30" maxlength="30" placeholder="Confirm New Pin"></td>
            </tr>
            <tr>
                <td style="text-align: right; height: 100px;"><input class="btn btn-danger" name="btn_pin" type="submit" value="Save Changes" onclick="return ValidPin()"></td>
                <td style="text-align: left; height: 100px; padding-left: 25px;"><button class="btn btn-dark" type="reset">Clear</button></td>
            </tr>
        </table></center>

    </form>

</div>

<!--Page Content End-->

</body>
</html>
