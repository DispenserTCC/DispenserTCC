<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="DispenserTCC.Home" MasterPageFile="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!DOCTYPE html>
<html>
  <head>
    <meta charset="UTF-8" />
    <title>Tela Pós-Login</title>
    <link rel="stylesheet" href="estilo.css" />
    <%--<style>
      body {
        margin: 0;
        padding: 0;
        font-family: Arial, sans-serif;
        background-color: #f0f0f0;
        overflow: hidden;
      }

      #menu1-button {
        position: fixed;
        top: 20px;
        left: 20px;
        background-color: #ffffff;
        color: #050505;
        border: none;
        padding: 10px 20px;
        box-shadow: 0px 0px 10px rgba(30, 10, 249, 0.953);
        cursor: pointer;
      }

      #menu1 {
        position: fixed;
        top: 0;
        left: -250px;
        width: 250px;
        height: 100%;
        background-color: #3498db;
        color: #fff;
        transition: left 1s;
      }

      #menu1 ul {
        list-style: none;
        padding: 0;
      }

      #menu1 ul li {
        padding: 10px;
      }

      #menu1 ul li a {
        color: #fff;
        text-decoration: none;
      }
    </style>--%>
  </head>
  <body>
    <%--<button id="menu1-button">MENU</button>--%>
    <div id="menu1">
      <ul>
          
        <li><asp:Button id="btnGerarRelatorio" CssClass="menu1" OnClick="btnGerarRelatorio_Click" runat="server" text="Gerar Relatório"/></li>
        <li><asp:Button id="btnProgramarDispensador" CssClass="menu1" OnClick="btnProgramarDispensador_Click" runat="server" text="Programar Dispensador"/></li>
        <li><asp:Button id="btnLogout" CssClass="menu1" OnClick="btnLogout_Click" runat="server" text="Sair"/></li>
      </ul>
    </div>
    <%--<script>
      const menuButton = document.getElementById("menu1-button");
      const menu = document.getElementById("menu1");

      menuButton.addEventListener("click", () => {
        if (menu.style.left === "0px") {
          menu.style.left = "-250px";
        } else {
          menu.style.left = "0px";
        }
      });
    </script>--%>
  </body>
</html>
</asp:Content>
