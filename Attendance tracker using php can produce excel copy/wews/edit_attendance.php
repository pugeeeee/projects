<?php
include 'db.php';

if (isset($_GET['id'])) {
    $id = $_GET['id'];
    $sql = "SELECT * FROM attendance WHERE id = $id";
    $result = $conn->query($sql);
    $row = $result->fetch_assoc();
} else {
    echo "Invalid ID";
    exit();
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Edit Attendance</title>
    <link rel="stylesheet" href="attend.css">
</head>
<body>
    <h2>Edit Attendance Record</h2>
    <form action="update_attendance.php" method="POST">
        <input type="hidden" name="id" value="<?php echo $row['id']; ?>">
        <label>Name:</label>
        <input type="text" name="name" value="<?php echo $row['name']; ?>" required>
        <label>Date:</label>
        <input type="date" name="date" value="<?php echo $row['date']; ?>" required>
        <label>Time In:</label>
        <input type="time" name="time_in" value="<?php echo $row['time_in']; ?>">
        <label>Lunch Out:</label>
        <input type="time" name="lunch_out" value="<?php echo $row['lunch_out']; ?>">
        <label>Lunch In:</label>
        <input type="time" name="lunch_in" value="<?php echo $row['lunch_in']; ?>">
        <label>Time Out:</label>
        <input type="time" name="time_out" value="<?php echo $row['time_out']; ?>">
        <button type="submit">Update</button>
    </form>
</body>
</html>
