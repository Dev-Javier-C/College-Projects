<?php
    session_start();
    include 'connection.php';
    $conn = OpenCon();

    $name = $_POST['user_name'];
    $username = $_POST['user_username'];
    $password = $_POST['user_password'];

    $s = "select * from user where user_username = '$username'";
    $result = mysqli_query($conn, $s);
    $num = mysqli_num_rows($result);
    if($num == 1)
    {
        echo "Username Taken";
    }
    else 
    {
        $reg = "insert into user(user_name, user_username, user_password) values('$name','$username','$password')";
        mysqli_query($conn, $reg);
        echo "Registration Successful";
    }

    CloseCon($conn);
?>