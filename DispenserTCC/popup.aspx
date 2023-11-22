@{
    ViewBag.Title = "Auto Dismissible Pop-up";
}

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Auto Dismissible Pop-up</title>
    <style>
        .overlay {
            display: none;
            position: fixed;
            top: 0;
            left: 0;
            width: 100%;
            height: 100%;
            background: rgba(0, 0, 0, 0.5);
            align-items: center;
            justify-content: center;
        }

        .popup {
            background: #fff;
            padding: 20px;
            border-radius: 5px;
            text-align: center;
        }

        .caution-symbol {
            color: yellow;
            font-size: 36px;
            margin-bottom: 10px;
        }

        .dismissed-text {
            color: #333;
            font-size: 18px;
        }
    </style>
</head>
<body>
    <!-- The overlay and pop-up content -->
    <div class="overlay" id="overlay">
        <div class="popup">
            <div class="caution-symbol">&#9888;</div>
            <div class="dismissed-text">Medicamento Dispensado</div>
        </div>
    </div>

    <script>
        function showAndDismissPopup() {
            document.getElementById("overlay").style.display = "flex";
            setTimeout(dismissPopup, 3000); // Auto dismiss after 3 seconds (adjust as needed)
        }

        function dismissPopup() {
            document.getElementById("overlay").style.display = "none";
        }

        showAndDismissPopup();
    </script>
</body>
</html>