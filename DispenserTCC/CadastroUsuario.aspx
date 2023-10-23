<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroUsuario.aspx.cs" Inherits="DispenserTCC.CadastroUsuario" %>

<!DOCTYPE html>
<html lang="pt-br">
  <head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Cadastro</title>
    <link rel="stylesheet" href="CSS/Estilo.css" />
  </head>
  <body>
    <div class="login-container">
      <h2>Cadastro do Usuário</h2>
      <form action="process_login.php" method="POST">
        <div class="form-group">
          <label for="username">Nome Completo:</label>
          <input type="text" id="user" name="user" required />
        </div>
        <div class="form-group">
          <label for="username">CPF:</label>
          <input
            type="tel"
            id="document"
            name="inputdocument"
            placeholder="XXX.XXX.XXX-XX"
            required
          />
        </div>
        <div class="form-group">
          <label for="username">Data de Nascimento:</label>
          <input type="date" id="birthday" name="birthday" required />
        </div>
        <div class="form-group">
          <label for="phone">Número de telefone:</label>
          <input type="text" id="phone" name="phone" maxlength="12" required />
        </div>
        <div class="form-group">
          <label for="password">Senha:</label>
          <input type="password" id="password" name="password" required />
        </div>
        <button type="submit" class="login-button">Cadastrar-se</button>
        <a class="login-button" href="login.html">Login</a>
      </form>
    </div>
  </body>
</html>