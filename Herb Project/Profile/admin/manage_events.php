<?php
//checking connection and session start
include "../../connection_files/connection.php";
?>
<?php error_reporting(E_ERROR | E_PARSE); unset($_SESSION['e_id']); ?>
<?php
//redirecting unauthorized admins
if(!isset($_SESSION['admin-pin']))
{
    header("location:../../LoginPage/logIn.php");
}
?>
<script lang="JavaScript" type="text/javascript">
    function DeleteEvent() {
        let text = "This Action Will Delete This Event Permanently From the Web Site and Database.\nContinue the Action?";
        if (confirm(text) == true)
        {
            return true;
        }
    }
</script>
<?php
$events_list = '';
$search='';
$sql='';
if ( isset($_GET['search']) ) {
    $search = mysqli_real_escape_string($connection, $_GET['search']);
    $sql = "SELECT * FROM items WHERE (item_id LIKE '%{$search}%' OR item_name LIKE '%{$search}%') ORDER BY item_id ASC";
    $_SESSION['on_search']= "<a style='color: white; text-decoration: none' href='manage_events.php'><i class='fa fa-arrow-left'></i>&nbsp;&nbsp;Back to Full item List</a>";
}else{
    $sql="SELECT * FROM items ORDER BY item_id ASC";

}
$items=mysqli_query($connection,$sql);
if($items)
{
    while ($item=mysqli_fetch_assoc($items))
    {

        $items_list .= "<tr>" ;

        $items_list .= "<td>{$item['item_id']}</td>" ;
        $items_list .= "<td>{$item['item_name']}</td>" ;
        $items_list .= "<td>{$item['price']}</td>" ;
        $items_list .= "<td>{$item['published_date_time']}</td>" ;
        $items_list .= "<td style='text-align: center;'><button class='conf_edit'><a id='edit' href=\"edit_event.php?item_id={$item['item_id']}\">Edit</a></button></td>" ;
        $items_list .= "<td style='text-align: center;'><button class='conf_delete' onclick='return DeleteEvent()==true'><a id='delete' href=\"delete.php?item_id={$item['item_id']}\">delete</a></button></td>" ;

        $items_list .= "</tr>" ;
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
    <title>Admin Profile (Manage Items)</title>
    <link rel="icon" href="logo.jfif">

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
    <a href="#" style="color: forestgreen;">Manage Items</a><br>
    <a href="credentials.php">Account Security</a>
    <br><br>
    <button id="btnlo" onclick="return ConfLogout()==true"><a href="../logout.php">Logout</a></button>
</div>

<!--Page Content Start-->

<div class="content-admin">
    <?php if(isset($_SESSION['published_msg'])): ?>
        <div class="alert alert-<?=$_SESSION['published_msg_type']?>">
            <?php
            echo $_SESSION['published_msg'];
            unset($_SESSION['published_msg']);
            unset($_SESSION['published_msg_type']);
            ?>
        </div>
    <?php endif; ?>

    <?php if(isset($_SESSION['delmsg_events'])): ?>
        <div class="alert alert-<?=$_SESSION['delmsg_type_events']?>">
            <?php
            echo $_SESSION['delmsg_events'];
            unset($_SESSION['delmsg_events']);
            unset($_SESSION['delmsg_type_events']);
            ?>
        </div>
    <?php endif; ?>

    <h2 style="text-align: center;font-weight: bold;">Process Management</h2><br>
    <a href="add_event.php"> <button type="button" class="btn btn-primary"><i class="fa fa-plus" aria-hidden="true"></i>&nbsp; Publish a New Item</button></a>
    <br>
    <!--search box-->
    <br>
    <div class="form-group has-search">
        <form action="manage_events.php" name="search-form" method="get">
            <span class="fa fa-search form-control-feedback"></span>
            <input type="text" name="search" value="<?php echo $search ?>" class="form-control" placeholder="Type Item ID or Name and PRESS ENTER " autofocus required>
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
            <th scope="col">Item_ID</th>
            <th scope="col">Item Name</th>
            <th scope="col">Price</th>
            <th scope="col">Published Date & Time</th>
            <th scope="col">Edit Item</th>
            <th scope="col">Delete Item</th>
        </tr>
        </thead>
        <tbody>
        <?php
        echo $items_list;
        ?>
        </tbody>
    </table>


</div>

<!--Page Content End-->

</body>
</html>
