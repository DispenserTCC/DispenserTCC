<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Relatorio.aspx.cs" Inherits="DispenserTCC.Relatorio" MasterPageFile="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Relatório</title>
    <link rel="stylesheet" href="CSS/Estilo.css" />
  </head>
  <body>
    <div class="login-container">
      <h2>Gerar Relatório</h2>
      <form action="process_login.php" method="POST">
        <div class="form-group">
          <label for="username">
              Para gerar o relatório atualizado clique no botão abaixo:</label>
        </div>
          <asp:Button id="btnGerarRelatorio" CssClass="menu1" OnClick="btnGerarRelatorio_Click" runat="server" text="Baixar Relatório"/>
      </form>
    </div>
  </body>
</html>
</asp:Content>