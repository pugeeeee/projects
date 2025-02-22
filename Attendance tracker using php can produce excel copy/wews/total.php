<?php
include 'db.php';

date_default_timezone_set('Asia/Manila');

// Fetch total hours worked for each employee, ensuring negative values are set to zero
$sql = "SELECT name, 
        SEC_TO_TIME(GREATEST(0, SUM(TIME_TO_SEC(TIMEDIFF(time_out, time_in)) - 
        IF(lunch_out IS NOT NULL AND lunch_in IS NOT NULL, TIME_TO_SEC(TIMEDIFF(lunch_in, lunch_out)), 0)))) AS total_hours
        FROM attendance 
        WHERE time_in IS NOT NULL AND time_out IS NOT NULL
        GROUP BY name
        ORDER BY name ASC";

$result = $conn->query($sql);
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Total Hours Worked</title>
    <link rel="stylesheet" href="attend.css"> 
</head>
<body>

    <nav>
        <div class="nav-container">
            <img src="pics/cna.png" alt="CNA Logo" class="logo"/>
            <div class="nav-links">
                <a href="attend.php" class="anchor back-btn">Back to Attendance</a>
                <a href="logout.php" class="anchor logout-btn">Logout</a>
            </div>
        </div>
    </nav>

    <div class="attendance-container" id="attends-total">
        <h2 id="totalwork">Total Hours Worked</h2>

        <table class="attendance-table">
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Total Hours</th>
                </tr>
            </thead>
            <tbody>
                <?php
                if ($result->num_rows > 0) {
                    while ($row = $result->fetch_assoc()) {
                        echo "<tr>
                                <td>{$row['name']}</td>
                                <td>{$row['total_hours']}</td>
                              </tr>";
                    }
                } else {
                    echo "<tr><td colspan='2'>No records found</td></tr>";
                }
                ?>
            </tbody>
        </table>
    </div>

</body>
</html>
