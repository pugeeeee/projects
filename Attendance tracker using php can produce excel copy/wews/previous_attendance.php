<?php
include 'db.php';

date_default_timezone_set('Asia/Manila');

// Default date filters
$selected_month = isset($_GET['month']) ? $_GET['month'] : date('Y-m'); // Default to current month
$selected_day = isset($_GET['day']) ? $_GET['day'] : date('Y-m-d'); // Default to today

// Fetch unique months from attendance records
$month_query = "SELECT DISTINCT DATE_FORMAT(date, '%Y-%m') AS month FROM attendance ORDER BY month DESC";
$month_result = $conn->query($month_query);

?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Attendance Records</title>
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

    <div class="attendance-container">
        <h2 id="record">Attendance Records</h2>

        <!-- Filter Selection -->
        <form method="GET">
        

            <label id="day" for="day">Select Day:</label>
            <input type="date" name="day" id="day" value="<?php echo $selected_day; ?>" onchange="this.form.submit()">
        </form>

        <table class="attendance-table">
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Date</th>
                    <th>Time In</th>
                    <th>Lunch Out</th>
                    <th>Lunch In</th>
                    <th>Time Out</th>
                </tr>
            </thead>
            <tbody>
                <?php
                // Fetch records for the selected month and day
                $sql = "SELECT * FROM attendance 
                        WHERE DATE_FORMAT(date, '%Y-%m') = '$selected_month'
                        AND date = '$selected_day' 
                        ORDER BY date ASC, name ASC";

                $result = $conn->query($sql);

                if ($result->num_rows > 0) {
                    while ($row = $result->fetch_assoc()) {
                        echo "<tr>
                                <td>{$row['name']}</td>
                                <td>{$row['date']}</td>
                                <td>{$row['time_in']}</td>
                                <td>{$row['lunch_out']}</td>
                                <td>{$row['lunch_in']}</td>
                                <td>{$row['time_out']}</td>
                              </tr>";
                    }
                } else {
                    echo "<tr><td colspan='6'>No attendance records found</td></tr>";
                }
                ?>
            </tbody>
        </table>
    </div>

</body>
</html>
