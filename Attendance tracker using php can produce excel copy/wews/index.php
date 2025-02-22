<?php
session_start();
require 'db.php'; // Database connection

// Handle AJAX requests (Login & Signup)
if ($_SERVER["REQUEST_METHOD"] === "POST") {
    header("Content-Type: application/json");
    $data = json_decode(file_get_contents("php://input"), true);

    if (!isset($data["action"])) {
        echo json_encode(["success" => false, "error" => "Invalid request"]);
        exit();
    }

    $username = trim($conn->real_escape_string($data["username"]));
    $password = $data["password"];

    if ($data["action"] === "login") {
        $sql = "SELECT * FROM users WHERE username = ?";
        $stmt = $conn->prepare($sql);
        $stmt->bind_param("s", $username);
        $stmt->execute();
        $result = $stmt->get_result();
        $user = $result->fetch_assoc();

        if ($user && password_verify($password, $user["password"])) {
            $_SESSION['username'] = $user["username"];
            echo json_encode(["success" => true, "redirect" => "attend.php"]);
        } else {
            echo json_encode(["success" => false, "error" => "Invalid credentials"]);
        }
    } elseif ($data["action"] === "signup") {
        $passwordHash = password_hash($password, PASSWORD_DEFAULT);
        $sql = "INSERT INTO users (username, password) VALUES (?, ?)";
        $stmt = $conn->prepare($sql);
        $stmt->bind_param("ss", $username, $passwordHash);

        if ($stmt->execute()) {
            echo json_encode(["success" => true, "message" => "Signup successful"]);
        } else {
            echo json_encode(["success" => false, "error" => "Username already exists"]);
        }
    }

    $stmt->close();
    $conn->close();
    exit();
}

// Logout logic
if (isset($_GET['logout'])) {
    session_destroy();
    header("Location: index.php");
    exit();
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login Page</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>

    <!-- Navigation Bar -->
    <nav>
        <div class="nav-container">
        <img src="pics/cna.png" alt="CNA Logo" class="logo"/>
            <div class="nav-links">
                
                <?php if (isset($_SESSION['username'])): ?>
                    <a href="?logout=true">Logout (<?= $_SESSION['username'] ?>)</a>
                <?php else: ?>
                    <a class ="anchor" href="#" id="loginBtn">Login</a>
                    <a class ="anchor" href="#" id="signupBtn">Signup</a>
                <?php endif; ?>
            </div>
        </div>
    </nav>

    <!-- Main Content -->
    <div class="content">
    <div class="content1">
        <img src="pics/cna.png" alt="CNA Logo" id="logo2"/>
    </div>
    <div class="contentt">
        <h1 id="design">attendance tracker for ojt</h1>
    </div>
</div>


    <?php if (!isset($_SESSION['username'])): ?>
    <!-- Login Modal -->
    <div id="loginModal" class="modal">
        <div class="modal-content">
            <span class="close" onclick="closeModal('loginModal')">&times;</span>
            <h2>Login</h2>
            <form id="loginForm">
                <label for="login-username">Username</label>
                <input type="text" id="login-username" required>
                
                <label for="login-password">Password</label>
                <input type="password" id="login-password" required>
                
                <button type="submit">Login</button>
            </form>
        </div>
    </div>

    <!-- Signup Modal -->
    <div id="signupModal" class="modal">
        <div class="modal-content">
            <span class="close" onclick="closeModal('signupModal')">&times;</span>
            <h2>Signup</h2>
            <form id="signupForm">
                <label for="signup-username">Username</label>
                <input type="text" id="signup-username" required>
                
                <label for="signup-password">Password</label>
                <input type="password" id="signup-password" required>

                <label for="confirm-password">Confirm Password</label>
                <input type="password" id="confirm-password" required>
                
                <button type="submit">Register</button>
            </form>
        </div>
    </div>
    <?php endif; ?>

    <script>
        function openModal(id) {
            document.getElementById(id).style.display = "flex";
        }
        function closeModal(id) {
            document.getElementById(id).style.display = "none";
        }

        document.getElementById("loginBtn")?.addEventListener("click", () => openModal("loginModal"));
        document.getElementById("signupBtn")?.addEventListener("click", () => openModal("signupModal"));

        document.getElementById("loginForm")?.addEventListener("submit", async (event) => {
            event.preventDefault();
            const username = document.getElementById("login-username").value;
            const password = document.getElementById("login-password").value;

            const response = await fetch("index.php", {
                method: "POST",
                headers: { "Content-Type": "application/json" },
                body: JSON.stringify({ action: "login", username, password })
            });

            const data = await response.json();
            if (data.success) {
                alert("✅ Login successful!");
                window.location.href = data.redirect; // Redirect to attendance.php
            } else {
                alert("❌ " + data.error);
            }
        });

        document.getElementById("signupForm")?.addEventListener("submit", async (event) => {
            event.preventDefault();
            const username = document.getElementById("signup-username").value;
            const password = document.getElementById("signup-password").value;
            const confirmPassword = document.getElementById("confirm-password").value;

            if (password !== confirmPassword) {
                alert("❌ Passwords do not match!");
                return;
            }

            const response = await fetch("index.php", {
                method: "POST",
                headers: { "Content-Type": "application/json" },
                body: JSON.stringify({ action: "signup", username, password })
            });

            const data = await response.json();
            if (data.success) {
                alert("✅ Signup successful! Please login.");
                closeModal("signupModal");
            } else {
                alert("❌ " + data.error);
            }
        });
    </script>

</body>
</html>
