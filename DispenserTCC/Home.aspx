<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="DispenserTCC.Home" MasterPageFile="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <!DOCTYPE html>
<html lang="pt-br">
  <head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Paciente ou Médico</title>
    <link rel="stylesheet" href="CSS/Estilo.css" />
  </head>
  <body style="background: url(img/medicamentos.jpg); background-repeat:no-repeat; background-size:cover;">
    <div><asp:Button id="btnSair" CssClass="exit" OnClick="btnLogout_Click" runat="server" text="Sair"/></div>
      <h2>Menu de opções:</h2>
      <form action="process_login.php" method="POST">
        <div class="form-group">
          <label for="username"></label>
        </div>
        <asp:Button id="btnRelatorio" CssClass="login-button" OnClick="btnRelatorio_Click" runat="server" text="Gerar Relatório"/>
        <p></p>
        <asp:Button id="btnDispenser" CssClass="login-button" OnClick="btnDispenser_Click" runat="server" text="Configurar Dispenser"/>
      </form>
    </div>
  </body>
</html>
</asp:Content>
