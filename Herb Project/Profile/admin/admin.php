<?php
//checking connection and session start
include "../../connection_files/connection.php";
?>
<?php error_reporting(E_ERROR | E_PARSE); ?>
<?php
//redirecting unauthorized admins
if(!isset($_SESSION['admin-pin']))
{
    header("location:../../LoginPage/logIn.php");
}
?>
<script lang="JavaScript" type="text/javascript">
    function DeleteUser() {
        let text = "This Action Will Delete This User Permanently From the Database.\nContinue the Action?";
        if (confirm(text) == true)
        {
            return true;
        }
    }
</script>
<?php
$user_list = '';
$search='';
$sql='';
if ( isset($_GET['search']) ) {
    $search = mysqli_real_escape_string($connection, $_GET['search']);
    $sql = "SELECT id,first_name,last_name,username,email,mobile_number,gender,date FROM users WHERE (first_name LIKE '%{$search}%' OR last_name LIKE '%{$search}%' OR username LIKE '%{$search}%') AND username != 'admin' ORDER BY id ASC";
    $_SESSION['on_search']= "<a style='color: white; text-decoration: none' href='admin.php'><i class='fa fa-arrow-left'></i>&nbsp;&nbsp;Back to Full Users List</a>";
}else{
    $sql="SELECT id,first_name,last_name,username,email,mobile_number,gender,date FROM users WHERE username != 'admin' ORDER BY id ASC";

}
$users=mysqli_query($connection,$sql);
if($users)
{
    while ($user=mysqli_fetch_assoc($users))
    {

        $user_list .= "<tr>" ;

        $user_list .= "<td>{$user['id']}</td>" ;
        $user_list .= "<td>{$user['first_name']}</td>" ;
        $user_list .= "<td>{$user['last_name']}</td>" ;
        $user_list .= "<td>{$user['username']}</td>" ;
        $user_list .= "<td>{$user['email']}</td>" ;
        $user_list .= "<td>{$user['mobile_number']}</td>" ;
        $user_list .= "<td>{$user['gender']}</td>" ;
        $user_list .= "<td>{$user['date']}</td>" ;
        $user_list .= "<td><button class='conf_delete' onclick='return DeleteUser()==true'><a id='delete' href=\"delete.php?user_id={$user['id']}\">delete</a></button></td>" ;

        $user_list .= "</tr>" ;
    }

}
else
{
    echo "Database  related error ".$connection->error;
}

?>

<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="icon" href="logo.jfif">
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
    <title>Admin Profile (Manage Users)</title>

</head>
<body>

<div class="sidenav">
    <div id="div-btn-back">
    <button id="back-btn"><a href="../../home.php"><i class="fa fa-arrow-circle-left" id="icon"></i></a></button>
    </div>
    <img src="admin.png" alt="admin_avatar">
    <h1>ADMINISTRATOR</h1>
    <br><br>
    <a href="#"style="color: forestgreen;">Manage Users</a><br>
    <a href="manage_events.php">Manage Items</a><br>
    <a href="credentials.php">Account Security</a>
    <br><br>
    <button id="btnlo" onclick="return ConfLogout()==true"><a href="../logout.php">Logout</a></button>
</div>

<div class="content-admin">
<!--Page Content Stat-->
    <?php if(isset($_SESSION['delmsg'])): ?>
    <div class="alert alert-<?=$_SESSION['delmsg_type']?>">
        <?php
        echo $_SESSION['delmsg'];
        unset($_SESSION['delmsg']);
        unset($_SESSION['delmsg_type']);
        ?>
    </div>
    <?php endif; ?>
    <h2 style="text-align: center;font-weight: bold;">Users List of NSBM Community Portal</h2>
    <!--search box-->
    <br>
    <div class="form-group has-search">
        <form action="admin.php" name="search-form" method="get">
        <span class="fa fa-search form-control-feedback"></span>
        <input type="text" name="search" value="<?php echo $search ?>" class="form-control" placeholder="Type First Name, Last Name or Username and PRESS ENTER " autofocus required>
            <?php
            if(isset($_SESSION['on_search'])){
                echo "<br>".$_SESSION['on_search'];
                unset($_SESSION['on_search']);
            }
            ?>
        </form>
    </div>

    <table class="table table-bordered table-dark">
        <thead>
        <tr>
            <th scope="col">ID</th>
            <th scope="col">First Name</th>
            <th scope="col">Last Name</th>
            <th scope="col">Username</th>
            <th scope="col">Email</th>
            <th scope="col">Mobile Number</th>
            <th scope="col">Gender</th>
            <th scope="col">Joined Date & Time</th>
            <th scope="col">Delete</th>
        </tr>
        </thead>
        <tbody>
        <?php
        echo $user_list;
        ?>
        </tbody>
    </table>
<!--Page Content End-->
</div>

</body>
</html>
