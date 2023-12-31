﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroUsuario.aspx.cs" Inherits="DispenserTCC.CadastroUsuario" MasterPageFile="~/Site.Master"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!DOCTYPE html>
    <html lang="pt-br">
      <head>
        <meta charset="UTF-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1.0" />
        <title>Cadastro</title>
        <link rel="stylesheet" href="CSS/Estilo.css" />
      </head>
      <body style="background: url(img/medicamentos.jpg); background-repeat:no-repeat; background-size:cover;">
        <div class="login-container">
          <h2>Cadastro do Usuário</h2>
          <form action="process_login.php" method="POST">
            <div class="form-group">
              <label for="username">Nome Completo:</label>
                <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
              <label for="username">CPF:</label>
                <asp:TextBox ID="txtNumDocumento" runat="server" Placeholder="XXX.XXX.XXX-XX"></asp:TextBox>
            </div>
            <div class="form-group">
              <label for="phone">Número de telefone:</label>
                <asp:TextBox ID="txtNumTelefone" runat="server" TextMode="Phone" Placeholder="(XX) X.XXXX-XXXX"></asp:TextBox>
            </div>
            <div class="form-group">
              <label for="phone">Email:</label>
                <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" Placeholder="EX:seuemail@gmail.com"></asp:TextBox>
            </div>
            <div class="form-group">
              <label for="password">Senha:</label>
                <asp:TextBox ID="txtSenha" TextMode="Password" runat="server"></asp:TextBox>
            </div>
            <asp:Button id="btnCadastrar" CssClass="login-button" OnClick="btnCadastrar_Click" runat="server" text="Criar Usuário"/>
          </form>
        </div>
      </body>
    </html>
</asp:Content>