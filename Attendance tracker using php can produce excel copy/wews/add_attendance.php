<?php
include 'db.php';

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $name = $_POST['name'];
    $date = $_POST['date'];
    $time_in = $_POST['time_in'];
    $lunch_out = $_POST['lunch_out'];
    $lunch_in = $_POST['lunch_in'];
    $time_out = $_POST['time_out'];

    $sql = "INSERT INTO attendance (name, date, time_in, lunch_out, lunch_in, time_out) 
            VALUES ('$name', '$date', '$time_in', '$lunch_out', '$lunch_in', '$time_out')";

    if ($conn->query($sql) === TRUE) {
        echo "New record added successfully!";
        header("Location: index.php"); // Redirect back to main page
        exit();
    } else {
        echo "Error: " . $sql . "<br>" . $conn->error;
    }
}

$conn->close();
?>
