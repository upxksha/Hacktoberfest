
<?php
//redirecting main credential page  if first step isn't complete
if (!isset($_SESSION['username']))
{
    header("location:../Login/LogIn.php");
}
if(isset($_POST['sub_and_reg'])) {
    if ($_FILES['dp']['size'] != 0)
    {
//Avatar image
        $avatar = addslashes(file_get_contents($_FILES['dp']['tmp_name']));
    }
//declaring and assigning values to variables
    $headline = mysqli_real_escape_string($connection,$_POST['headline']) ;
    $bio = mysqli_real_escape_string($connection,$_POST['bio']) ;
    $username = $_SESSION['username'];

    $user_reg_sql = "UPDATE users SET avatar='$avatar',headline='$headline',bio='$bio' WHERE username='$username' LIMIT 1";
    if ($connection->query($user_reg_sql) == true) {
        header("location:../Login/LogIn.php");

    } else {
        echo "Database Connection Error........" . $connection->error;
    }
}
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <title>Registration Step 2</title>
    <link rel="stylesheet" type="text/css" href="Reg.css">
    <link rel="stylesheet" type="text/css" href="../bootstrap/bootstrap1.css">
    <script lang="javascript" type="text/javascript">
    </script>
</head>

<body>
    <div class="logbox" id="avtupload">
        <p id="message">( You can skip this step and complete the registration process if you wish )</p><br>

        <form name="logform_2" method="post" enctype="multipart/form-data" action="photouploadpage.php" onsubmit="">

        <!--Avatar-->
        <div class="profile_avatar">
            <center><img id="blah" class="rounded" src="avatar_default.png" alt="Your Avatar" class="img-responsive rounded" id="avt_preview"></center>
            <br>
            <center><label class="btn btn-primary ">
                Choose an Avatar<input accept="image/*" type="file" id="imgInp" name="dp" hidden  onchange="document.getElementById('blah').src = window.URL.createObjectURL(this.files[0])">  </label></center>
        </div>
        <br>

        <!--Headline-->
        <div class="profile_headline">
            <div class="form-group col-md-12">
                <label for="headline">Headline</label>
                <input type="text" class="form-control" id="headline" name="headline"
                       placeholder="Enter a headline for the Profile"
                       maxlength="47">
            </div>
        </div>

        <!--Bio-->
        <div class="profile_bio">
            <label for="bio">Bio</label><br><br>
            <textarea class="form-control" id="bio" name="bio" rows="4" maxlength="500"
                      placeholder="Tell people about yourself"></textarea>
        </div>
        <br>

        <!--submit $ register-->
        <div id="div_SR">
        <input type="submit" id="SR" name="sub_and_reg" value="Finish & Log In">
        </div>
        </form>
    </div>


</body>

</html>