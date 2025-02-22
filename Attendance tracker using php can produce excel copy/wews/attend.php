<?php
include 'db.php';

date_default_timezone_set('Asia/Manila'); // Set timezone
$current_date = date('Y-m-d'); // Get today's date

// Handle adding a new person
if ($_SERVER["REQUEST_METHOD"] == "POST" && isset($_POST['add'])) {
    $name = trim($_POST['name']);
    $time_in = $_POST['time_in'];
    $lunch_out = $_POST['lunch_out'];
    $lunch_in = $_POST['lunch_in'];
    $time_out = $_POST['time_out'];

    // Check if the name already exists for today
    $check_sql = "SELECT id FROM attendance WHERE name = '$name' AND date = '$current_date'";
    $check_result = $conn->query($check_sql);

    if ($check_result->num_rows > 0) {
        echo "Error: Name already exists for today!";
    } else {
        $sql = "INSERT INTO attendance (name, date, time_in, lunch_out, lunch_in, time_out) 
                VALUES ('$name', '$current_date', '$time_in', '$lunch_out', '$lunch_in', '$time_out')";

        echo ($conn->query($sql) === TRUE) ? "Success" : "Error: " . $conn->error;
    }
    exit;
}

// Handle updating an existing record
if ($_SERVER["REQUEST_METHOD"] == "POST" && isset($_POST['update'])) {
    $id = $_POST['id'];
    $time_in = $_POST['time_in'];
    $lunch_out = $_POST['lunch_out'];
    $lunch_in = $_POST['lunch_in'];
    $time_out = $_POST['time_out'];

    $sql = "UPDATE attendance SET 
            time_in='$time_in', 
            lunch_out='$lunch_out', 
            lunch_in='$lunch_in', 
            time_out='$time_out' 
            WHERE id='$id'";

    echo ($conn->query($sql) === TRUE) ? "Success" : "Error: " . $conn->error;
    exit;
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Attendance Tracker</title>
    <link rel="stylesheet" href="attend.css">
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script> <!-- jQuery for AJAX -->
</head>
<body>

    <nav>
        <div class="nav-container">
            <img src="pics/cna.png" alt="CNA Logo" class="logo"/>
            <div class="nav-links">
                <a href="previous_attendance.php" class="anchor">Attendance Record</a>
                <a href="total.php" class="anchor total-btn">Total Hours</a>
                <a href="logout.php" class="anchor logout-btn">Logout</a>
            </div>
        </div>
    </nav>

    <div class="attendance-container">
        <h2 class="h2">Today's Attendance (<?php echo $current_date; ?>)</h2>
        
        <button id="addPersonBtn">Add Person</button>

        <div id="addPersonForm" style="display:none;">
            <input type="text" id="new_name" placeholder="Enter Name" required>
            <input type="time" id="new_time_in">
            <input type="time" id="new_lunch_out">
            <input type="time" id="new_lunch_in">
            <input type="time" id="new_time_out">
            <button onclick="addPerson()">Submit</button>
            <button onclick="closeForm()">Cancel</button>
        </div>

        <table class="attendance-table">
            <thead>
                <tr>
                    <!-- ID Column Hidden -->
                    <th>Name</th>
                    <th>Date</th>
                    <th>Time In</th>
                    <th>Lunch Out</th>
                    <th>Lunch In</th>
                    <th>Time Out</th>
                    <th>Action</th>
                </tr>
            </thead>
            <tbody id="attendanceTable">
                <?php
                $sql = "SELECT * FROM attendance WHERE date='$current_date' ORDER BY id ASC";
                $result = $conn->query($sql);

                if ($result->num_rows > 0) {
                    while ($row = $result->fetch_assoc()) {
                        echo "<tr id='row_{$row['id']}'>
                                <td style='display:none;'>{$row['id']}</td> <!-- Hidden ID -->
                                <td>{$row['name']}</td>
                                <td>{$row['date']}</td>
                                <td><span id='time_in_{$row['id']}'>{$row['time_in']}</span><input type='time' id='edit_time_in_{$row['id']}' value='{$row['time_in']}' style='display:none;'></td>
                                <td><span id='lunch_out_{$row['id']}'>{$row['lunch_out']}</span><input type='time' id='edit_lunch_out_{$row['id']}' value='{$row['lunch_out']}' style='display:none;'></td>
                                <td><span id='lunch_in_{$row['id']}'>{$row['lunch_in']}</span><input type='time' id='edit_lunch_in_{$row['id']}' value='{$row['lunch_in']}' style='display:none;'></td>
                                <td><span id='time_out_{$row['id']}'>{$row['time_out']}</span><input type='time' id='edit_time_out_{$row['id']}' value='{$row['time_out']}' style='display:none;'></td>
                                <td>
                                    <button onclick='editRow({$row['id']})' id='edit_btn_{$row['id']}'>Edit</button>
                                    <button onclick='updateRow({$row['id']})' id='save_btn_{$row['id']}' style='display:none;'>Save</button>
                                </td>
                        </tr>";
                    }
                } else {
                    echo "<tr><td colspan='7'>No attendance records found for today.</td></tr>";
                }
                ?>
            </tbody>
        </table>
    </div>

    <script>
        document.getElementById("addPersonBtn").addEventListener("click", function() {
            document.getElementById("addPersonForm").style.display = "block";
        });

        function closeForm() {
            document.getElementById("addPersonForm").style.display = "none";
        }

        function addPerson() {
            var name = document.getElementById("new_name").value.trim();
            var time_in = document.getElementById("new_time_in").value;
            var lunch_out = document.getElementById("new_lunch_out").value;
            var lunch_in = document.getElementById("new_lunch_in").value;
            var time_out = document.getElementById("new_time_out").value;

            if (name === "") {
                alert("Name cannot be empty!");
                return;
            }

            $.post('attend.php', { add: 1, name, time_in, lunch_out, lunch_in, time_out }, function(response) {
                if (response.trim() === "Success") location.reload();
                else alert(response);
            });
        }

        function editRow(id) {
            $(`#time_in_${id}, #lunch_out_${id}, #lunch_in_${id}, #time_out_${id}`).hide();
            $(`#edit_time_in_${id}, #edit_lunch_out_${id}, #edit_lunch_in_${id}, #edit_time_out_${id}`).show();
            $(`#edit_btn_${id}`).hide();
            $(`#save_btn_${id}`).show();
        }

        function updateRow(id) {
            $.post('attend.php', {
                update: 1,
                id: id,
                time_in: $(`#edit_time_in_${id}`).val(),
                lunch_out: $(`#edit_lunch_out_${id}`).val(),
                lunch_in: $(`#edit_lunch_in_${id}`).val(),
                time_out: $(`#edit_time_out_${id}`).val()
            }, function(response) {
                if (response.trim() === "Success") location.reload();
                else alert("Error updating record.");
            });
        }
    </script>

</body>
</html>
