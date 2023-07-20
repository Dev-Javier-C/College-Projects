<?php
    session_start();
    include 'connection.php';
    $conn = OpenCon();

    $username = $_POST['user_username'];
    $password = $_POST['user_password'];

    $s = "select * from user where user_username = '$username' && user_password = '$password'";
    $result = mysqli_query($conn, $s);
    $num = mysqli_num_rows($result);
    if($num == 1)
    {
        $_SESSION['user_username'] = $name;
        header('location:home.php');
    }
    else 
    {
        header('location:login.html');
    }

    CloseCon($conn);
?>