<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DispenserTCC.Login" MasterPageFile="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
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
            <img src="img/login.jpeg" />
          <form action="process_login.php" method="POST">
            <div class="form-group">
              <label for="username">Email:</label>
              <%--<input type="number" id="user" name="user" required />--%>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>  
            </div>
            <div class="form-group">
              <label for="password">Senha:</label>
                <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
            </div>
              <asp:Button id="btnEntrar" CssClass="login-button" OnClick="btnEntrar_Click" runat="server" text="Entrar"/>
              <asp:Button id="btnCadastrar" CssClass="login-button" OnClick="btnCadastrar_Click" runat="server" text="Cadastre-se"/>
          </form>
        </div>
      </body>
    </html>
</asp:Content>
