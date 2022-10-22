<html>
<head>
<title>Welcome to NSBM transport booking platform | login</title>
<link rel="stylesheet" href="style.css">
<script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
</head>

<body>
<div class="loginbox">
<img src="images/profile.jpg" class="avatar">
<h1>Log-in Here</h1>

<form method="post" action="">

<p>Username</p>
<input type="text" name="user" value="" required placeholder="Enter Username">
<p>Password</p>
<input type="password" name="pass" required   value="" placeholder="Enter Password">
<br/><br/><br/><br/>
<input type="submit" name="login" value="Login"></a>
</form>
</div>

<?php      
    

    
        include 'dbcon.php';  
          //to prevent from mysqli injection  
       

        if(isset($_POST['login']))
        {
          $username = mysqli_real_escape_string($dbcon, $_POST['user']);  
        $password = mysqli_real_escape_string($dbcon, $_POST['pass']);  

      
        $sql = "select * from users where username = '$username' and password = '$password'";  
        $result = mysqli_query($dbcon, $sql);  
        $row = mysqli_fetch_array($result, MYSQLI_ASSOC);  
        $count = mysqli_num_rows($result);  
          
        if($count == 1){  
            header("Location:Home Page.html");
        }  
        else{  
            echo "<script>swal({
                title: 'Something went wrong!',
                text: 'Check login Details!',
                icon: 'warning',
                button: 'OK!',
              });</script>";  
        }     
    }
?>  


</body>
</html>