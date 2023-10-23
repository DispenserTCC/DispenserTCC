<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Configuracoes.aspx.cs" Inherits="DispenserTCC.Configuracoes" %>

<!DOCTYPE html>
<html lang="pt-br">
  <head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Config. Dispenser</title>
    <link rel="stylesheet" href="CSS/Estilo.css" />
  </head>
  <body>
    <div class="login-container">
      <h2>Configurações</h2>
      <form action="process_login.php" method="POST">
        <div class="form-group">
          <label for="username">Selecione o dispenser:</label>
          <select class="selection-button" name="product" id="product">
            <option value="1">Dispenser 1</option>
            <option value="2">Dispenser 2</option>
            <option value="3">Dispenser 3</option>
            <option value="4">Dispenser 4</option>
          </select>
        </div>
        <div class="form-group">
          <label for="username">Formato do medicamento:</label>
          <select class="selection-button" name="type" id="type">
            <option value="comprido">Comprido</option>
            <option value="capsula">Cápsula</option>
            <option value="dragea">Drágea</option>
          </select>
        </div>
      </form>
    </div>
  </body>
</html>