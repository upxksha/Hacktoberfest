<?php
//checking connection and session start
include "../../connection_files/connection.php";
?>
<?php
//redirecting unauthorized admins
if(!isset($_SESSION['admin-pin']))
{
    header("location:../../LoginPage/logIn.php");
}
?>
<?php
$_SESSION['item_id']=$_GET['item_id'];

//Read data for display values
$sql="SELECT * FROM items WHERE item_id={$_SESSION['item_id']} LIMIT 1";
$read=mysqli_query($connection,$sql);
$data=mysqli_fetch_assoc($read);

?>
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Admin Profile (Edit item)</title>
    <link rel="icon" href="logo.jfif">
    <link rel="stylesheet" type="text/css" href="../bootstrap1.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <style>
        body
        {
            font-family: 'Poppins', sans-serif;
            background-color:#6c757d;
        }
        .cover
        {
            width: 300px;
            height: 200px;
        }

    </style>

</head>
<body>
<?php if(isset($_SESSION['published_msg_F'])): ?>
    <div class="alert alert-<?=$_SESSION['published_msg_type_F']?>">
        <?php
        echo $_SESSION['published_msg_F'];
        unset($_SESSION['published_msg_F']);
        unset($_SESSION['published_msg_type_F']);
        ?>
    </div>
<?php endif; ?>
<table><tr>
        <td style="width: 200px; text-align: left;padding-top: 30px;padding-left: 35px;">
            <a href="manage_events.php"><i class="fa fa-arrow-circle-left" style="font-size: 50px; color: #ffffff"></i></a>
        </td>
        <td style="width: 720px; text-align: right;">
            <h2 style="font-weight: bold; text-align: right; padding-top: 20px; padding-right: 70px;">Edit Item</h2>
        </td>
    </tr></table>
<br>
<form name="item_edit" method="post" enctype="multipart/form-data" action="edit_process.php" >
    <div class="form-row" style="background-color:transparent; width: 1000px; margin-right: auto;
  margin-left: auto;">

        <div class="form-group">
            <label for="event_name"><h5 style="font-weight: bold">Enter the Item Name / Topic</h5></label>
            <input type="text" name="it_name" class="form-control" id="item_name" placeholder="Event Name / Topic" value="<?php echo $data['item_name'];?>" required>
        </div>
        <br>
        <div class="form-group">
            <label for="Textarea2"><h5 style="font-weight: bold">Enter Details About Item</h5></label>
            <textarea name="details" class="form-control rounded-0" id="Textarea2" rows="5" cols="5" maxlength="2500" required><?php echo $data['description'];?></textarea>
        </div>
        <br>
        <table>
            <tr>
                <td style="vertical-align: top; width: 600px">
                    <label for="datetime"><h5 style="font-weight: bold">Enter Price</h5></label>
                    <br>
                    <input type="text" id="price_text" name="price_area" value="<?php echo $data['price'];?>" required>
                </td>
                <td style="width: 600px;" >
                    <!--image-->
                    <center><img id="blah" class="cover" src="cover.jpg" alt="Cover photo" class="img-responsive rounded" id="avt_preview"></center>
                    <br>
                    <center><label class="btn btn-primary ">
                            Change Cover Photo<input  accept="image/*" type="file" id="imgInp" name="cp" hidden  onchange="document.getElementById('blah').src = window.URL.createObjectURL(this.files[0])">  </label></center>
                </td>
            </tr>

        </table>
        <table>
            <tr>
                <td style="text-align: right; height: 100px;"><input class="btn btn-danger" name="edit_now" id="publish" type="submit" value="Save Changes"></td>
            </tr>
        </table>


    </div>



</form>
</body>
</html>