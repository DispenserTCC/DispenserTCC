<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RelatorioDispenser.aspx.cs" Inherits="DispenserTCC.Relatorio" MasterPageFile="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Relatório</title>
    <link rel="stylesheet" href="CSS/Estilo.css" />
  </head>
  <body style="background: url(img/medicamentos.jpg); background-repeat:no-repeat; background-size:cover;">
     <div><asp:Button id="btnSair" CssClass="exit" OnClick="btnLogout_Click" runat="server" text="Sair"/></div>
      <h2>Gerar Relatório</h2>
      <form action="process_login.php" method="POST">
        <div class="form-group">
          <label style="text-align: center" for="username">Para gerar o relatório atualizado clique no botão abaixo:</label>
        </div>
          <asp:Button id="btnGerarRelatorio" CssClass="login-button" OnClick="btnGerarRelatorio_Click" runat="server" text="Baixar Relatório"/>
      </form>
    </div>
  </body>
</html>
</asp:Content>