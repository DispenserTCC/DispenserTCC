<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Configuracoes.aspx.cs" Inherits="DispenserTCC.Configuracoes" MasterPageFile="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<!DOCTYPE html>
<html lang="pt-br">
  <head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Config. Dispenser</title>
    <link rel="stylesheet" href="CSS/Estilo.css" />
  </head>
  <body style="background: url(img/medicamentos.jpg); background-repeat:no-repeat; background-size:cover;">
    <div class="login-container">
      <h2>Configurações</h2>
      <form action="process_login.php" method="POST">
                  <div class="form-group">
          <label for="username">Nome: </label>
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        </div>
        <%--<div class="form-group">
          <label for="username">Digite qual o dispenser: </label>
            <asp:TextBox ID="txtDispenser" runat="server" Placeholder="1, 2, 3 ou 4"></asp:TextBox>
        </div>--%>
        <div class="form-group">
          <label for="username">Nome do medicamento: </label>
           <asp:TextBox ID="txtMedicamento" runat="server" Placeholder="Ex: Dorflex"></asp:TextBox>
        </div>
        <div class="form-group">
          <label for="username">Quantidade: </label>
           <asp:TextBox ID="txtQuantidade" runat="server" Placeholder="Total:"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="username">Intervalo(em horas): </label>
            <asp:TextBox ID="txtIntervalo" runat="server" Placeholder=""></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="username">Por quantos dias: </label>
            <asp:TextBox ID="txtQtdDias" runat="server" Placeholder="Ex: 5"></asp:TextBox>
        </div>
        <div class="form-group">
          <label for="username">Data:</label>
            <asp:TextBox ID="txtData_prescricao" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
          <label for="username">Hora:</label>
            <asp:TextBox ID="txtHora_prescricao" runat="server" ></asp:TextBox>
        </div>
        <div>
          <asp:Button id="btnSalvar" CssClass="login-button" OnClick="btnSalvar_Click" runat="server" text="Feito"/>
        </div>
        </div>
      </form>
    </div>
  </body>
</html>
</asp:Content>