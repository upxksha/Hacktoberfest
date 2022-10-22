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
if(isset($_POST['publish_now']))
{
    $image = addslashes(file_get_contents($_FILES['cp']['tmp_name']));
    $herb=mysqli_real_escape_string($connection,$_POST['herb']);
    $details=mysqli_real_escape_string($connection,$_POST['details']);
    $price=mysqli_real_escape_string($connection,$_POST['price']);
    $sql_publish="INSERT INTO items (item_name,price,description,picture) VALUES ('$herb','$price','$details','$image') LIMIT 1";
    $result=mysqli_query($connection,$sql_publish);
    if($result)
    {
        $_SESSION['published_msg']="Event has been successfully published !!!!";
        $_SESSION['published_msg_type']="success";
        header("location:manage_events.php");
    }
    else
    {
        $_SESSION['published_msg_F']="Uploaded Image doesn't Support...or ".$connection->error;
        $_SESSION['published_msg_type_F']="danger";
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
    <title>Admin Profile (Publish Event)</title>
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
    <script lang="javascript" type="text/javascript">
        function valid()
        {
            if(document.getElementById("imgInp").value == "") {
                window.alert("Please Upload a Cover Photo");
                return false;
            }

        }

    </script>

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
            <h2 style="font-weight: bold; text-align: right; padding-top: 20px">Publish a New Event</h2>
        </td>
    </tr></table>
<br>
<form name="events_publish" method="post" enctype="multipart/form-data" action="add_event.php" >
    <div class="form-row" style="background-color:transparent; width: 1000px; margin-right: auto;
  margin-left: auto;">

        <div class="form-group">
            <label for="herb"><h5 style="font-weight: bold">Enter the Herb Name </h5></label>
            <input type="text" name="herb" class="form-control" id="event_name" placeholder="Event Name / Topic" autofocus required>
        </div>
        <br>
        <div class="form-group">
            <label for="Textarea2"><h5 style="font-weight: bold">Enter Details About Herb</h5></label>
            <textarea name="details" class="form-control rounded-0" id="Textarea2" rows="5" cols="5" maxlength="2500" required></textarea>
        </div>
        <br>
        <table>
            <tr>
                <td style="vertical-align: top; width: 600px">
                    <label for="price"><h5 style="font-weight: bold">Price</h5></label>
                    <br>
                    <input type="text" id="price" name="price" required>
                </td>
                <td style="width: 600px;" >
                    <!--image-->
                    <center><img id="blah" class="cover" src="cover.jpg" alt="Cover photo" class="img-responsive rounded" id="avt_preview"></center>
                    <br>
                    <center><label class="btn btn-primary ">
                            Upload a item Image<input  accept="image/*" type="file" id="imgInp" name="cp" hidden  onchange="document.getElementById('blah').src = window.URL.createObjectURL(this.files[0])" required>  </label></center>
                </td>
            </tr>

        </table>


        <table>
            <tr>
                <td style="text-align: right; height: 100px;"><input class="btn btn-success" name="publish_now" id="publish" type="submit" value="Publish Now" onclick="valid()"></td>
                <td style="text-align: left; height: 100px; padding-left: 25px;"><a href="add_event.php"><input type="button" class="btn btn-dark" value="Clear"></a></td>
            </tr>
        </table>


    </div>



</form>
</body>
</html>