<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaInicial.aspx.cs" Inherits="DispenserTCC.PaginaInicial"  MasterPageFile="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!DOCTYPE html>
    <html lang="pt-br">
      <head>
        <meta charset="UTF-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1.0" />
        <title>Seja bem vindo</title>
        <link rel="stylesheet" href="CSS/Estilo.css" />
        <style></style>
      </head>
      <body>
        <div class="welcome-container">
          <h1>Seja bem-vindo ao nosso site</h1>
          <p>Primeiro acesso? clique no botão abaixo para se cadastrar!!!</p>
          <asp:Button id="btnEntrar" CssClass="login-button" OnClick="btnEntrar_Click" runat="server" text="Login"/>
            <asp:Button id="btnCadastrar" CssClass="login-button" OnClick="btnCadastrar_Click" runat="server" text="Cadastre-se"/>
          <p>Agradecemos a sua preferência!</p>
        </div>
      </body>
    </html>
</asp:Content>
