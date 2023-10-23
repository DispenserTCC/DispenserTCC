<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DispenserTCC.Login" %>

<!DOCTYPE html>
<html lang="pt-br">
  <head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Login</title>
    <link rel="stylesheet" href="CSS/Estilo.css" />
    <style></style>
  </head>
  <body>
    <div class="login-container">
      <h2>Login</h2>
      <form action="process_login.php" method="POST">
        <div class="form-group">
          <label for="username">Númeração do Dispenser:</label>
          <input type="number" id="user" name="user" required />
        </div>
        <div class="form-group">
          <label for="password">Senha:</label>
          <input type="password" id="password" name="password" required />
        </div>
        <button type="submit" class="login-button">Login</button>
        <a class="login-button" href="cadastro.html">Cadastrar-se</a>
      </form>
    </div>
  </body>
</html>
