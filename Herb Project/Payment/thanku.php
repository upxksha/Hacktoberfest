<?php
//checking connection and session start
include "../connection_files/connection.php";
?>
<?php
//redirecting to index if user or admin is unknown
if(!isset($_SESSION['username_logged']) and !isset($_SESSION['admin-pin']))
{
    header("location:../Login/LogIn.php");
}
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Thank you</title>
    <link rel="icon" href="logo.jfif">
    <link rel="stylesheet" href="../home.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/css/all.min.css"/>
    <link rel="stylesheet" href="bootstrap/bootstrap1.css">

    <script lang="JavaScript" type="text/javascript">
        function ConfLogout() {
            let text = "You will be logged out as a result of this Action.\nContinue the Action?";
            if (confirm(text) == true)
            {
                return true;
            }
        }
    </script>

</head>
<body style="background-color:#000000; ">
<nav>
    <div class="navpanel">
        <div class="logo"><a href="../home.php"><img src="logo.jfif"> </a></div>
        <input type="radio" name="responsive_slide" id="menu-btn">
        <input type="radio" name="responsive_slide" id="close-btn">
        <l class="nav-links">
            <label for="close-btn" class="btn close-btn"><i class="fas fa-times"></i></label>
            <li><a href="../home.php">Home</a></li>
            <li><a href="../search.php">Search &nbsp<i class="fa fa-search"></i> </a></li>

            <label for="close-btn" class="btn close-btn"><i class="fas fa-times"></i></label>
            <li><a href="../massagebox/chat.php">Help</a></li>

            <li>
                <a href="#" class="clubs_and_societies_navigation">My Profile &nbsp;<i class="fa fa-caret-down"></i></a>
                <input type="checkbox" id="showDrop">
                <label for="showDrop" class="clubs">My Profile &nbsp;<i class="fa fa-caret-down"></i></label>
                <ul class="my_profile-dropbox">
                    <li><a href="../profile/profile.php">View</a></li>
                    <li><a onclick="return ConfLogout()==true" href="../profile/logout.php">Log Out</a></li>
                </ul>
            </li>
        </l>
        <label for="menu-btn" class="btn menu-btn"><i class="fas fa-bars"></i></label>
    </div>
</nav>
<h1 class="thk">Thank you for using our webstore to purchase</h1>